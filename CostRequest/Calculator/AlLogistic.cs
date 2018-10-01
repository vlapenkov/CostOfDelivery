using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CostRequest.Calculator
{       
    public class AlLogistic : ICalculator
    {
        public AlLogistic(IConfiguration configuration)
        {
            Configuration = configuration;
            _gKey = Configuration["_gKey"];
        }
        public IConfiguration Configuration { get; set; }

        private readonly string _gKey;

        public string CompanyName { get; set; } = "AlLogistic";

        public async Task<string> GetPriceAsync(string inCity, string outCity, double weight)
        {
            string url = @"http://allogistik.ru/ajax/special-rate.php";
            if (weight <= 0) return "Неправильно указан вес";

            var outCityInfo = await GetCityIdAsync(outCity);
            if (outCityInfo == null) return "Неизвестный город отправления";
            
            var inCityInfo = await GetCityIdAsync(inCity);
            if(inCityInfo == null) return "Неизвестный город получения";

            int typeTransport = SelectCar((int)weight);
            string distance = GetDistanceBetweenCities(outCityInfo.PROPERTY_MAP_VALUE, inCityInfo.PROPERTY_MAP_VALUE);

            using (var client = new WebClient())
            {
                // Создаём коллекцию параметров
                var pars = new NameValueCollection
                {
                    // Добавляем необходимые параметры в виде пар ключ, значение
                    { "cityIn", inCityInfo.NAME },
                    { "cityOut", outCityInfo.NAME },
                    { "distance", distance.ToString() },
                    { "transportType", typeTransport.ToString() },
                    { "cityInId", inCityInfo.ID.ToString() },
                    { "cityOutId", outCityInfo.ID.ToString() }
                };

                // Посылаем параметры на сервер
                var response = await client.UploadValuesTaskAsync(url, pars);
                //Конвертируем данные из байтов в строку, а строку в JSON и отправляем клиенту
                var data = JsonConvert.DeserializeObject<Dictionary<string, string>>(Encoding.GetEncoding("UTF-8")
                   .GetString(response, 0, response.Length));
                if (data == null)
                {
                    return "Через менеджера";
                }
                return data.First().Value;
            }
        }

        #region приватные вспомогательные методы
        private string GetDistanceBetweenCities(string cityACoords, string cityBCoords)
        {
            // string gKey = "AIzaSyBd_7Xjo_N5QSRRmzTHERgZmX3QO9gK6eM";//
                          // "AIzaSyD0jr02Zqe4rH1wnR7cRbAZhAsQHra1pvM";//myKey not work :(
            var coordsA = cityACoords.Split(',');
            var coordsB = cityBCoords.Split(',');
            string path = $@"https://maps.googleapis.com/maps/api/distancematrix/json?destinations={coordsA[0]},{coordsA[1]}&origins={coordsB[0]},{coordsB[1]}&key={_gKey}&language=ru&unit=metric&departure_time=now";

            using (var client = new WebClient())
            {
                var response = client.DownloadData(path);
                var data = JsonConvert.DeserializeObject<GoogleAnswer>(Encoding.GetEncoding("UTF-8")
                  .GetString(response, 0, response.Length));

                if (data.rows[0].elements[0]?.status == "OK")
                {
                    var dataStr = data.rows[0].elements[0]?.distance?.text;// '1100км.' 
                    char nonbreakingSpace = (char)160;
                    var result = dataStr.Substring(0, dataStr.Length - 3).Replace(nonbreakingSpace, ' ').Replace(" ", "");
                    //  var result = string.Concat(dataStr.Where(d => d != dataStr.Last())).Replace(' ');
                    return result;
                }
                else
                {
                    return data.status;
                }
            }

        }

        private async Task<AlLogisticModel> GetCityIdAsync(string name)
        {
            string url = "http://allogistik.ru/ajax/cities.php";

            using (var webClient = new WebClient())
            {
                // Создаём коллекцию параметров
                var pars = new NameValueCollection
                {
                    // Добавляем необходимые параметры в виде пар ключ, значение
                    { "search", name }
                };

                // Посылаем параметры на сервер
                var response = await webClient.UploadValuesTaskAsync(url, pars);
                //Конвертируем данные из байтов в строку, а строку в JSON и отправляем серверу
                var data = JsonConvert.DeserializeObject<AlLogisticModel[]>(Encoding.GetEncoding("UTF-8")
                   .GetString(response, 0, response.Length));

                return data.FirstOrDefault();
            }
        }

        /*в зависимости от массы груза, автоматически подбирается авто
         но если груз больше 20 тонн, выберется самая грузоподъемная, хоть она и расчитана до 
             */
        private int SelectCar(int weight) => weight >= 2000 ? (weight >= 5000 ? (weight > 10000 ? (weight < 20000 ? 2395 : 2395) : 2394) : 2393) : 2392;


        
        #endregion
    }
}

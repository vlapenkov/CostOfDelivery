using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using System.Net;
using System.Collections.Specialized;
using CalcApi.Models.AlLogistic;

namespace CalcApi.Controllers
{
    [Produces("application/json")]
    [Route("api/AlLogistic")]
    public class AlLogisticController : Controller
    {

        [HttpGet]
        public async Task<string> GetCost(string inCity, string outCity, int weight)
        {
            string url = @"http://allogistik.ru/ajax/special-rate.php";

            var outCityInfo = await GetCityIdAsync(outCity);
            var inCityInfo = await GetCityIdAsync(inCity);
            int typeTransport = SelectCar(weight);
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
            var coordsA = cityACoords.Split(',');
            var coordsB = cityBCoords.Split(',');
            string path = $@"https://maps.googleapis.com/maps/api/distancematrix/json?destinations={coordsA[0]},{coordsA[1]}&origins={coordsB[0]},{coordsB[1]}&key=AIzaSyBd_7Xjo_N5QSRRmzTHERgZmX3QO9gK6eM&language=ru&unit=metric&departure_time=now";

            using (var client = new WebClient())
            {
                var response = client.DownloadData(path);
                var data = JsonConvert.DeserializeObject<GoogleAnswer>(Encoding.GetEncoding("UTF-8")
                  .GetString(response, 0, response.Length));
              
                var dataStr=data.rows[0].elements[0].distance.text;// '1100км.' 
                char nonbreakingSpace = (char)160;
                var result = dataStr.Substring(0, dataStr.Length - 3).Replace(nonbreakingSpace, ' ').Replace(" ","");
              //  var result = string.Concat(dataStr.Where(d => d != dataStr.Last())).Replace(' ');
                return result;                  
            }

        }

        private async Task<AlLogistic> GetCityIdAsync(string name)
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
                var data = JsonConvert.DeserializeObject<AlLogistic[]>(Encoding.GetEncoding("UTF-8")
                   .GetString(response, 0, response.Length));

                return data.FirstOrDefault();
            }
        }

        /*в зависимости от массы груза, автоматически подбирается авто
         но если груз больше 20 тонн, выберется самая грузоподъемная, хоть она и расчитана до 
             */
        private int SelectCar(int weigth) => weigth >= 2000 ? (weigth >= 5000 ? (weigth > 10000 ? (weigth < 20000 ? 2395 : 2395) : 2394) : 2393) : 2392;
        #endregion
    }
}
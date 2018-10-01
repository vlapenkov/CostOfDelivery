using HtmlAgilityPack;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CostRequest.Calculator
{
    public class EastLine:ICalculator
    {
        public Task<string> GetPriceAsync(string inCity, string outCity, double weight)
        {
            return GetPriceFromSite(outCity, inCity, GetCar(outCity, inCity, (int)weight));
        }

        #region приватные вспомогательные методы
        /*сайт автоматически подбирает размер машины в зависимости от веса груза*/
        private string GetCar(string inCity, string outCity, int weight)
        {
            if (weight <= 0) return "Неправильно указан вес";

            string url = $@"https://www.eastlines.ru/raschet-stoimosti/?from={outCity}&from-place-id=&from-reference=&where={inCity}&where-place-id=&where-reference=&weight={weight}";

            var pageContent = LoadPage(url).Result;
            var document = new HtmlDocument();
            document.LoadHtml(pageContent);

            HtmlNodeCollection collection = document.DocumentNode.SelectNodes("//script[@type='text/javascript' and contains(.,'var selected_car_id = ')]");
            if (collection == null) return null;
            var neededRow = collection.First().InnerText.Split('\n').Where(r => r.Contains("selected_car_id")).First().Split('=').Last().Trim(';').Trim(' ');
           
            return neededRow;
        }
        /*парсинг страницы с расчетами*/
        private async Task<string> LoadPage(string url)
        {
            var result = "";
            var request = (HttpWebRequest) WebRequest.Create(url);
            var response = (HttpWebResponse)await request.GetResponseAsync();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var receiveStream = response.GetResponseStream();
                if (receiveStream != null)
                {
                    StreamReader readStream;
                    if (response.CharacterSet == null)
                        readStream = new StreamReader(receiveStream);
                    else
                        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                    result = readStream.ReadToEnd();
                    readStream.Close();
                }
                response.Close();
            }
            return result;
        }

        private async Task<string> GetPriceFromSite(string inCity, string outCity, string car)
        {           
            string url = @"https://www.eastlines.ru";
            using (var client = new WebClient())
            {
                // Создаём коллекцию параметров
                var pars = new NameValueCollection();

                // Добавляем необходимые параметры в виде пар ключ, значение
                pars.Add("action", "getCalcInfo");
                pars.Add("module", "calc");
                pars.Add("city1", inCity);
                pars.Add("city2", outCity);
                pars.Add("car", car);

                // Посылаем параметры на сервер
                var response = await client.UploadValuesTaskAsync(url, pars);
                //Конвертируем данные из байтов в строку, а строку в JSON и отправляем серверу
                var deserealizedResult= JsonConvert.DeserializeObject<Dictionary<string, string>>(Encoding.GetEncoding("UTF-8")
                  .GetString(response, 0, response.Length));
                string value = "Цена устанавливается через менеджера";
                 deserealizedResult.TryGetValue("price", out value);
                return value.Replace(" ","");
            }
        }


        #endregion
    }
}

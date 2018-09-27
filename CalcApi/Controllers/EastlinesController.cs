using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalcApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Eastlines")]
    public class EastlinesController : Controller
    {

        [HttpGet]
        public Dictionary<string, string> GetCost(string outCity, string inCity, int weight, int value)
        {
            return GetREsultFromSite(outCity, inCity, GetCar(outCity, inCity, weight, value));
        }

        #region приватные вспомогательные методы
        /*сайт автоматически подбирает размер машины в зависимости от веса груза*/
        private int GetCar(string inCity, string outCity, int weight, int volume)
        {
            //тэг span.number
            string url = $@"https://www.eastlines.ru/raschet-stoimosti/?from={outCity}&from-place-id=&from-reference=&where={inCity}&where-place-id=&where-reference=&weight={weight}&volume={volume}";

            var pageContent = LoadPage(url);
            var document = new HtmlDocument();
            document.LoadHtml(pageContent);

            HtmlNodeCollection collection = document.DocumentNode.SelectNodes("//script[@type='text/javascript' and contains(.,'var selected_car_id = ')]"); 

            //  var neededRow = collection.First().InnerText.Split('\n')[6].Split('=').Last().Trim(';').Trim(' ');
            var neededRow = collection.First().InnerText.Split('\n').Where(r => r.Contains("selected_car_id")).First().Split('=').Last().Trim(';').Trim(' ');
            int result = 0;
            int.TryParse(neededRow, out result);
            Console.WriteLine(result.ToString());

            return result;
        }
        /*парсинг страницы с расчетами*/
        private string LoadPage(string url)
        {
            var result = "";
            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();

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

        private Dictionary<string, string> GetREsultFromSite(string inCity, string outCity, int car)
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
                pars.Add("car", car.ToString());

                // Посылаем параметры на сервер
                var response = client.UploadValues(url, pars);
                //Конвертируем данные из байтов в строку, а строку в JSON и отправляем серверу
                return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(Encoding.GetEncoding("UTF-8")
                  .GetString(response, 0, response.Length));
            }
        }
        #endregion
    }
}
using DpdCalculator;
using DpdGeography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostRequest.Calculator
{
    public class Dpd : ICalculator
    {
        public async Task<string> GetPriceAsync(string inCity, string outCity, double weight)
        {
         return  await CalculateCostAsync(inCity, outCity, weight);
        }
        public Dpd()
        {
            if (_tempListOfCities == null)
                _tempListOfCities = getCities().Result;
        }
        protected void UpdateData()
        {
                _tempListOfCities = getCities().Result;
        }

        private readonly string clientKey = "6078E6EF054E13F442B4A46ADDE226628F946EDC";
        private readonly long clientNumber = 1007003275;

        private static DpdGeography.city[] _tempListOfCities;

        /*получаем и сохраняем список городов, чтобы не загружать его каждый раз*/
        private async Task<DpdGeography.city[]> getCities()
        {
            var geo = new DPDGeography2Client();
            /*  getCitiesCashPay  */
            var citiesCashPay = await geo.getCitiesCashPayAsync(new dpdCitiesCashPayRequest { auth = new DpdGeography.auth { clientKey = clientKey, clientNumber = clientNumber } });
            return citiesCashPay.@return;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inCity"></param>
        /// <param name="outCity"></param>
        /// <param name="weight">Вес (кг)</param>
        /// <param name="volume">объем m3(не обязательно)</param>
        /// <returns></returns>
        private async Task<string> CalculateCostAsync(string inCityName, string OutCityName, double weight)
        {
            if (weight <= 0) return "Неправильно указан вес";

            DpdCalculator.city inCity = CastGeoCityToCalcCity(FindCityByFullName(inCityName));
            if (inCity == null) return "Неизвестный город отправления";
            DpdCalculator.city outCity = CastGeoCityToCalcCity(FindCityByFullName(OutCityName));
            if (inCity == null) return "Неизвестный город получения";

            var client = new DPDCalculatorClient();

            var serviceRequest = new serviceCostRequest
            {
                auth = new DpdCalculator.auth
                {
                    clientKey = clientKey,
                    clientNumber = clientNumber
                },
                pickup = new cityRequest
                {
                    cityId = inCity.cityId,
                    cityIdSpecified = inCity.cityIdSpecified,
                    cityName = inCity.cityName,
                    countryCode = inCity.countryCode,
                    regionCode = inCity.regionCode,
                    regionCodeSpecified = inCity.regionCodeSpecified
                },// new CityRequestExtend(inCity),
                delivery = new cityRequest
                {
                    cityId = outCity.cityId,
                    cityIdSpecified = outCity.cityIdSpecified,
                    cityName = outCity.cityName,
                    countryCode = outCity.countryCode,
                    regionCode = outCity.regionCode,
                    regionCodeSpecified = outCity.regionCodeSpecified
                },// new CityRequestExtend(outCity),
                selfDelivery = false,
                selfPickup = false,
                weight = weight
            };

            var request = await client.getServiceCost2Async(serviceRequest);
            double min = request.@return.Min(c => c.cost);
            return request.@return.First(t=>t.cost==min).cost.ToString();
           // return request.@return.Where(rq => rq.cost == min).Select(p => p.cost).ToString();
        }

        /// <summary>
        /// get list of cities who name start with input string
        /// </summary>
        /// <param name="nameStartWith">Na</param>
        /// <returns></returns>
        private List<DpdGeography.city> GetCities(string nameStartWith)
        {
            if (nameStartWith.Length > 3)
                _tempListOfCities.Where(c => c.cityName.StartsWith(nameStartWith)).ToList();
            return null;
        }

        private DpdGeography.city FindCityByFullName(string cityName)
        {
            return _tempListOfCities.FirstOrDefault(s => s.cityName.StartsWith(cityName));

        }

        private DpdCalculator.city CastGeoCityToCalcCity(DpdGeography.city city)
        {
            if (city == null) return null;
            return new DpdCalculator.city
            {
                cityId = city.cityId,
                cityIdSpecified = city.cityIdSpecified,
                cityName = city.cityName,
                countryCode = city.countryCode,
                countryName = city.countryName,
                regionCode = city.regionCode,
                regionCodeSpecified = city.regionCodeSpecified,
                regionName = city.regionName
            };
        }

    }
}

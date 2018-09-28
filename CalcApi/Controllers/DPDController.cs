using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalcApi.Controllers
{
    [Produces("application/json")]
    [Route("api/DPD")]
    public class DPDController : Controller
    {
        public DPDController()
        {
            if(_tempListOfCities==null)
            _tempListOfCities = getCities().Result;
        }
       

        private readonly GeographyTest.auth _authdata = new GeographyTest.auth
        {
            clientKey = "6078E6EF054E13F442B4A46ADDE226628F946EDC",
            clientNumber = 1007003275
        };

        private static GeographyTest.city[] _tempListOfCities;

        /*получаем и сохраняем список городов, чтобы не загружать его каждый раз*/
        private async Task<GeographyTest.city[]>  getCities()
        {
            var geo = new DPDGeography2Client();
            /*  getCitiesCashPay  */
            var citiesCashPay = await geo.getCitiesCashPayAsync(new dpdCitiesCashPayRequest { auth = _authdata });            
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
        [HttpGet()]
        public async Task<serviceCost[]> CalculateCost(string inCityName, string OutCityName, double weight, double volume = 1)
        {
            DPDCalculatorTest.city inCity = CastGeoCityToCalcCity(FindCityByFullName(inCityName));
            DPDCalculatorTest.city outCity = CastGeoCityToCalcCity(FindCityByFullName(OutCityName));
            DPDCalculatorTest.auth auth = new DPDCalculatorTest.auth
            {
                clientKey = _authdata.clientKey,
                clientNumber = _authdata.clientNumber
            };
            var client = new DPDCalculatorClient();

            var serviceRequest = new serviceCostRequest
            {
                auth = auth,
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
                weight = weight,
                volume = volume
            };

            var request = await client.getServiceCost2Async(serviceRequest);
            return request.@return;
        }

        /// <summary>
        /// get list of cities who name start with input string
        /// </summary>
        /// <param name="nameStartWith">Na</param>
        /// <returns></returns>
        private List<GeographyTest.city> GetCities(string nameStartWith)
        {
            if (nameStartWith.Length > 3)
                 _tempListOfCities.Where(c => c.cityName.StartsWith(nameStartWith)).ToList();
            return null;
        }

        private GeographyTest.city FindCityByFullName(string cityName)
        {
            return _tempListOfCities.First(s=>s.cityName.StartsWith(cityName));
        }


        private DPDCalculatorTest.city CastGeoCityToCalcCity(GeographyTest.city city)
        {
            return new DPDCalculatorTest.city
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
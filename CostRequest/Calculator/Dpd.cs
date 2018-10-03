﻿using DpdCalculator;
using DpdGeography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CostRequest.Calculator
{
    public class Dpd : ICalculator
    {
        private IConfiguration Configuration { get; set; }

        public Dpd(IConfiguration configuration) 
        {
 
            Configuration = configuration;
            clientKey = Configuration["DpdClientKey"];
            clientNumber = Int64.Parse(Configuration["DpdClientNumber"]);
            if (_tempListOfCities == null)
            {
                _tempListOfCities = getCities().Result;
            }
        }

        private readonly string clientKey; 
        private readonly long clientNumber;
        private static DpdGeography.city[] _tempListOfCities;

        public string CompanyName { get; set; } = "Dpd";

        public async Task<string> GetPriceAsync(string inCity, string outCity, double weight)
        {
         return  await CalculateCostAsync(inCity, outCity, weight);
        }       

        /*получаем и сохраняем список городов, чтобы не загружать его каждый раз*/
        private async Task<DpdGeography.city[]> getCities()
        {
            var geo = new DPDGeography2Client();
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

            var inCity = CastGeoCityToCalcCity(FindCityByFullName(inCityName));
            if (inCity == null) return "Неизвестный город получения";
            var outCity = CastGeoCityToCalcCity(FindCityByFullName(OutCityName));
            if (outCity == null) return "Неизвестный город отправления";


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
                },
                delivery = new cityRequest
                {
                    cityId = outCity.cityId,
                    cityIdSpecified = outCity.cityIdSpecified,
                    cityName = outCity.cityName,
                    countryCode = outCity.countryCode,
                    regionCode = outCity.regionCode,
                    regionCodeSpecified = outCity.regionCodeSpecified
                },
                selfDelivery = false,//самопривоз самовывоз с терминала
                selfPickup = false,//самопривоз на терминал
                weight = weight,//*
                serviceCode = "MAX"//если сервис не задан возвращает список всех доступных услуг

            };

            var request = await client.getServiceCost2Async(serviceRequest);
            /*Если услуга была задана во входном сообщении, то при успешном выполнении запроса массив ответного сообщения будет состоять из одного элемента.*/
            return request.@return.First().cost.ToString();
        }

        private DpdGeography.city FindCityByFullName(string cityName)
        {
            var result = _tempListOfCities.FirstOrDefault(s => s.cityName.ToLower().Equals(cityName.ToLower()));
            return result;
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

using System;
using System.Collections.Generic;
using System.Text;
using DpdGeography;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace CostRequest.Services.Services
{
    public class CitiesService
    {
        private IConfiguration Configuration { get; set; }
        private readonly string clientKey;
        private readonly long clientNumber;
        private static city[] _tempListOfCities;
        /// <summary>
        /// Список городов по DPD
        /// </summary>
        public static List<string> ListOfCities
        {
            get
            {
                return _tempListOfCities.Select(s => s.cityName).ToList();
            }
        }

        /// <summary>
        /// Список городов начинающихся с указанного значения
        /// </summary>
        /// <param name="nameStart"></param>
        /// <returns></returns>
        public static List<string> ListOfCitiesStartWith(string nameStart)=> ListOfCities.Where(ls => ls.ToLower().StartsWith(nameStart.ToLower())).ToList();


        public CitiesService(IConfiguration configuration)
        {
            Configuration = configuration;
            clientKey = Configuration["DpdClientKey"];
            clientNumber = Int64.Parse(Configuration["DpdClientNumber"]);
            if (_tempListOfCities == null)
            {
                _tempListOfCities = GetCities().Result;
            }
        }

        private async Task<city[]> GetCities()
        {
            var geo = new DPDGeography2Client();
            var citiesCashPay = await geo.getCitiesCashPayAsync(new dpdCitiesCashPayRequest { auth = new auth { clientKey = clientKey, clientNumber = clientNumber } });
            return citiesCashPay.@return;
        }
    }
}

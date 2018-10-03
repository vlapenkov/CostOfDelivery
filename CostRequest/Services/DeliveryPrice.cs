using CostRequest.Calculator;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalcApi.Services
{
    public class DeliveryPriceService
    {

        private Dpd _dpd;
        private AlLogistic _alLogistic;
        private EastLine _eastLine;

        public DeliveryPriceService(Dpd dpd, AlLogistic alLogistic , EastLine eastLine )
        {
          //  _dpd = dpd;
            _alLogistic = alLogistic;
           // _eastLine = eastLine;
        }
      
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inCity">Куда</param>
        /// <param name="outCity">Откуда</param>
        /// <param name="weight">Вес</param>
        /// <returns>Цена доставки</returns>
        public async Task<Dictionary<string, string>> CalculateCostAsync(string inCity, string outCity, double weight)
        {
            if (weight <= 0) return new Dictionary<string, string> { { "Error", "Weigth  less or equal 0" } };
            var result = new Dictionary<string, string>();
            if (_dpd != null)
            {
                result.Add( _dpd.CompanyName,await _dpd.GetPriceAsync(inCity, outCity, weight));
            }
            if (_alLogistic != null)
            {
                result.Add(_alLogistic.CompanyName, await _alLogistic.GetPriceAsync(inCity, outCity, weight));
            }
            if(_eastLine!=null)
            {
                result.Add(_eastLine.CompanyName, await _eastLine.GetPriceAsync(inCity, outCity, weight));
            };
            return result;
        }
    }
}

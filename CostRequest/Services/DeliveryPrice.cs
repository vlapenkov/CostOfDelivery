using CostRequest.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalcApi.Services
{
    public class DeliveryPriceService 
    {

        public DeliveryPriceService(ICalculator dpd=null,ICalculator alLogistic = null, ICalculator eastLine = null)
        {
            _dpd = dpd;
            _alLogistic = alLogistic;
            _eastLine = eastLine;
        }
        private ICalculator _dpd;
        private ICalculator _alLogistic;
        private ICalculator _eastLine;
    

        public async Task<Dictionary<string, string>> CalculateCostAsync(string inCity, string outCity, double weight)
        {
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

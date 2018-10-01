using CostRequest.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalcApi.Services
{
    public class DeliveryPriceService 
    {
        public DeliveryPriceService(ICalculator dpd,ICalculator alLogistic,ICalculator eastLine)
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
            return new Dictionary<string, string>
            {
                {_dpd.CompanyName,await _dpd.GetPriceAsync(inCity,outCity,weight) },
                 {_alLogistic.CompanyName,await _alLogistic.GetPriceAsync(inCity,outCity,weight) },
                 {_eastLine.CompanyName,await _eastLine.GetPriceAsync(inCity,outCity,weight) }
            };
        }
    }
}

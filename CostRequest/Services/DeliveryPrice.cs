using CostRequest.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalcApi.Services
{
    public class DeliveryPriceService : IDeliveryPriceService
    {
        public DeliveryPriceService()
        {
            _calculatorsCollection = new List<ICalculator> { new Dpd(), new AlLogistic(), new EastLine() };
        }
        public DeliveryPriceService(IList<ICalculator> calculatorsCollection):this()
        {
            foreach (var item in calculatorsCollection)
            {
                _calculatorsCollection.Add(item);
            }         
        }

        private IList<ICalculator> _calculatorsCollection;  

        /// <summary>
        /// Return list of deilivery cost from collection of calculators
        /// </summary>
        /// <param name="inCity">City of departure</param>
        /// <param name="outCity">Pick up city</param>
        /// <param name="weight">Parcel Weigth</param>
        /// <returns>List name-cost</returns>
        public async Task<Dictionary<string, string>> GetCostsAsync(string inCity, string outCity, double weight)
        {
            var prices = new Dictionary<string, string>();
            foreach (var item in _calculatorsCollection)
            {
                prices.Add(item.GetType().Name, await item.GetPriceAsync(inCity, outCity, weight));
            }
            return prices;
        }
    }
}

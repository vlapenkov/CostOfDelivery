using CostRequest.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalcApi.Services
{
    public class DeliveryPriceService : IDeliveryPriceService
    {

        public async Task<Dictionary<string,string>>  GetCosts(string inCity, string outCity, double weigth)
        {
            List <ICalculator> list= new List<ICalculator>
            {
               new AlLogistic(),new Dpd(),new EastLine()
            };
            Dictionary<string, string> Prices = new Dictionary<string, string>();
            foreach (var item in list)
            {
                Prices.Add(item.GetType().Name, await item.GetPriceAsync( inCity,  outCity,  weigth));
            }
            return Prices;

        }

    }
}

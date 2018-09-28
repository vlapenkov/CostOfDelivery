using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalcApi.Services;
using CostRequest.Calculator;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalcApi.Controllers
{
    [Produces("application/json")]
    [Route("api/DeliveryPrice")]
    public class DeliveryPriceController : Controller
    {
        private IDeliveryPriceService PriceList = new DeliveryPriceService();

        public async Task< Dictionary<string,string>> GetPrice(string inCity, string outCity, double weigth)
        {
          return await  PriceList.GetCosts( inCity,  outCity,  weigth);
        }
    }
}
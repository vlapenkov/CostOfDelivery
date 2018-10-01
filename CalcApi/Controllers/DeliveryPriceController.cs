using System;
using System.Collections;
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
        private readonly DeliveryPriceService _service;
        public DeliveryPriceController(DeliveryPriceService service)
        {
            _service = service;
         //   PriceList = new DeliveryPriceService();
        }

        private DeliveryPriceService PriceList;

        public async Task<Dictionary<string,string>> GetPrice(string inCity, string outCity, double weight)
        {
            if (weight <= 0) return new Dictionary<string, string> { {"Error","Weigth  less or equal 0" } };
            return await _service.CalculateCostAsync( inCity,  outCity,  weight);        
        }
    }
}
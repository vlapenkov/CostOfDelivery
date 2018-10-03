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
        }
        /// <summary>
        /// /api/DeliveryPrice/GetPrice?inCity=Ярославль&outCity=Москва&weight=1000
        /// </summary>
        /// <param name="inCity"></param>
        /// <param name="outCity"></param>
        /// <param name="weight"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("getprice")]
        public async Task<Dictionary<string, string>> GetPrice(string inCity, string outCity, double weight) => await _service.CalculateCostAsync(inCity, outCity, weight);

        [HttpGet]
        [Route("test")]
        public string Test() => "test";
    }
}
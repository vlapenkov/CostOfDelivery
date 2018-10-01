using CostRequest.Calculator;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CalcApi.Services
{
    public interface IDeliveryPriceService
    {
        Task<Dictionary<string, string>> GetCostsAsync(string inCity, string outCity, double weight);
    }
}
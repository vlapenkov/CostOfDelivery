using System.Collections.Generic;
using System.Threading.Tasks;

namespace CalcApi.Services
{
    public interface IDeliveryPriceService
    {
        Task<Dictionary<string, string>> GetCosts(string inCity, string outCity, double weigth);
    }
}
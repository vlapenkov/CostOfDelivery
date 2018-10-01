using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostRequest.Calculator
{
   public interface ICalculator
    {       
        
    ///// <summary>
    ///// 
    ///// </summary>
    ///// <param name="inCity">Город приема</param>
    ///// <param name="outCity">Город Возврата</param>
    ///// <param name="weight">Масса груза в кг</param>
    ///// <returns></returns>
    //    string GetPrice(string inCity,string outCity,double weight);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inCity">Город приема</param>
        /// <param name="outCity">Город Возврата</param>
        /// <param name="weight">Масса груза в кг</param>
        /// <returns></returns>
        Task<string> GetPriceAsync(string inCity, string outCity, double weight);
        string CompanyName { get; set; }
    }
}

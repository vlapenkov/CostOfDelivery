using System;
using System.Collections.Generic;
using System.Text;

namespace CostRequest.Services.Models
{
  public  class DevAppSettings
    {
        /*класс для хранение секретов при разработке */
        public string _gKey { get; set; }
        public string DPDkey { get; set; }
        public long DpdClient { get; set; }

    }
}

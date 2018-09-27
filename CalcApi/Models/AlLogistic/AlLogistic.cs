using System;
using System.Linq;
using System.Threading.Tasks;

namespace CalcApi.Models.AlLogistic
{
    public class AlLogistic
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string PROPERTY_MAP_VALUE { get; set; }
        public int PROPERTY_MAP_VALUE_ID { get; set; }
        public int PROPERTY_REGION_VALUE { get; set; }
        public int PROPERTY_REGION_VALUE_ID { get; set; }
        public int SORT { get; set; }
        public string REGION { get; set; }
    }
}

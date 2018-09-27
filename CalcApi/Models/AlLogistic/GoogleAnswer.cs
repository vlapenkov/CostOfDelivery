using System.Collections.Generic;

namespace CalcApi.Models.AlLogistic
{
    public class GoogleAnswer
    {
        public List<string> destination_addresses { get; set; }
        public List<string> origin_addresses { get; set; }
        public List<Row> rows { get; set; }
        public string status { get; set; }
    }
}

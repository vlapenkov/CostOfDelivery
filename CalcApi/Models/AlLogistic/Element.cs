namespace CalcApi.Models.AlLogistic
{
    public class Element
    {
        public Distance distance { get; set; }
        public Duration duration { get; set; }
        public DurationInTraffic duration_in_traffic { get; set; }
        public string status { get; set; }
    }
}

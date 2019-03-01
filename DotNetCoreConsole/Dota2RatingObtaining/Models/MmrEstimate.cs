using RestSharp.Deserializers;

namespace DotNetCoreConsole.Dota2RatingObtaining.Models
{
    public class MmrEstimate
    {
        [DeserializeAs(Name = "estimate")]
        public int? Estimate { get; set; }

        [DeserializeAs(Name = "stdDev")]
        public int? StdDev { get; set; }

        [DeserializeAs(Name = "n")]
        public int? N { get; set; }
    }
}

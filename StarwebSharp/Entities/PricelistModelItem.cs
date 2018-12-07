using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class PricelistModelItem
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public PricelistModel Data { get; set; } = new PricelistModel();
    }
}
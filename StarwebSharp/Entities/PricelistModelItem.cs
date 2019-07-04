using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class PricelistModelItem
    {
        [JsonProperty("data")]
        public PricelistModel Data { get; set; } = new PricelistModel();
    }
}
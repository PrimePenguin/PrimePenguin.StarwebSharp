using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CurrencyModelItem
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public CurrencyModel Data { get; set; }
    }
}
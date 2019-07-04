using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CurrencyModelItem
    {
        [JsonProperty("data")]
        public CurrencyModel Data { get; set; }
    }
}
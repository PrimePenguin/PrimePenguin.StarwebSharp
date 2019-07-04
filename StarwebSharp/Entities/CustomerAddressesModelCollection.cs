using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CustomerAddressesModelCollection
    {
        [JsonProperty("data")]
        public Data Data { get; set; } = new Data();
    }
}
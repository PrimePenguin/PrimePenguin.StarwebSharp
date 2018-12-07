using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CustomerAddressesModelCollection
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public Data Data { get; set; } = new Data();
    }
}
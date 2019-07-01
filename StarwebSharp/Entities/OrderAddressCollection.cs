using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderAddressCollection
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public OrderAddressModel Data { get; set; }
    }
}
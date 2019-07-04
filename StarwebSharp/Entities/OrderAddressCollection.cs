using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderAddressCollection
    {
        [JsonProperty("data")]
        public OrderAddressModel Data { get; set; } = new OrderAddressModel();
    }
}
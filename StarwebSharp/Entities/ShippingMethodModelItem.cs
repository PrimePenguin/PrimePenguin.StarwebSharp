using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ShippingMethodModelItem
    {
        [JsonProperty("data")]
        public ShippingMethodModel Data { get; set; } = new ShippingMethodModel();
    }
}
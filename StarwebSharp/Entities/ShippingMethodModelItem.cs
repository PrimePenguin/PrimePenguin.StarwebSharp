using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ShippingMethodModelItem
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ShippingMethodModel Data { get; set; } = new ShippingMethodModel();
    }
}
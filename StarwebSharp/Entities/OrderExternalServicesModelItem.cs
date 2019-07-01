using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderExternalServicesModelItem
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public OrderExternalServiceModel Data { get; set; }
    }
}
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderExternalServicesModelItem
    {
        [JsonProperty("data")]
        public OrderExternalServiceModel Data { get; set; } = new OrderExternalServiceModel();
    }
}
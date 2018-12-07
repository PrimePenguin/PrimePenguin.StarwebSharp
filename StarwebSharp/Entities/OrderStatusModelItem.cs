using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderStatusModelItem
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public OrderStatusModel Data { get; set; } = new OrderStatusModel();
    }
}
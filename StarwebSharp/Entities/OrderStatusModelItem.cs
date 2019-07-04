using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderStatusModelItem
    {
        [JsonProperty("data")]
        public OrderStatusModel Data { get; set; } = new OrderStatusModel();
    }
}
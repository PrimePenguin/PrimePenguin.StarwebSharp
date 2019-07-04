using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderItemModelItem
    {
        [JsonProperty("data")]
        public OrderItemModel Data { get; set; } = new OrderItemModel();
    }
}
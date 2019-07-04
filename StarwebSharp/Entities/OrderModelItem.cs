using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderModelItem
    {
        [JsonProperty("data")]
        public OrderModel Data { get; set; } = new OrderModel();
    }
}
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderModelItem
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public OrderModel Data { get; set; }
    }
}
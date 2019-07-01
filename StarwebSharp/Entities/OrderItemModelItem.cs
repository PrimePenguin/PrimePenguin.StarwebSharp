using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderItemModelItem
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public OrderItemModel Data { get; set; }
    }
}
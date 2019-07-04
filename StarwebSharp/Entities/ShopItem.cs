using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ShopItem
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public ShopModel Data { get; set; }
    }
}
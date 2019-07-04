using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ShopItem
    {
        [JsonProperty("data")]
        public ShopModel Data { get; set; }
    }
}
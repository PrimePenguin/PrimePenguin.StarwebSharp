using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class BundledProductsModelItem
    {
        [JsonProperty("data")]
        public BundledProductsModel Data { get; set; }
    }
}
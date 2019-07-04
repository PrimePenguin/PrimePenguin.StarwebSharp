using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductBundleProductPriceModelItem
    {
        [JsonProperty("data")]
        public ProductBundleProductPriceModel Data { get; set; }
    }
}
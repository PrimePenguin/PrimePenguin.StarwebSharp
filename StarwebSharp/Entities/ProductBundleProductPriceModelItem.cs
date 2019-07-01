using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductBundleProductPriceModelItem
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public ProductBundleProductPriceModel Data { get; set; }
    }
}
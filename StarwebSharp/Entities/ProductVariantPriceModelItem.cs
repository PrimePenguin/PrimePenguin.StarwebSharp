using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVariantPriceModelItem
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ProductVariantPriceModel Data { get; set; } = new ProductVariantPriceModel();
    }
}
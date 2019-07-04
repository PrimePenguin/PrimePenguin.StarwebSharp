using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVariantPriceModelItem
    {
        [JsonProperty("data")]
        public ProductVariantPriceModel Data { get; set; } = new ProductVariantPriceModel();
    }
}
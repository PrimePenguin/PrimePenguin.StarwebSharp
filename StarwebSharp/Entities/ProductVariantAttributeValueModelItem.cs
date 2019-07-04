using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVariantAttributeValueModelItem
    {
        [JsonProperty("data")]
        public ProductVariantAttributeValueModel Data { get; set; } = new ProductVariantAttributeValueModel();
    }
}
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVariantAttributeValueModelItem
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ProductVariantAttributeValueModel Data { get; set; } = new ProductVariantAttributeValueModel();
    }
}
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVariantAttributeModelItem
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ProductVariantAttributeModel Data { get; set; } = new ProductVariantAttributeModel();
    }
}
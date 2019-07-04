using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVariantAttributeModelItem
    {
        [JsonProperty("data")]
        public ProductVariantAttributeModel Data { get; set; } = new ProductVariantAttributeModel();
    }
}
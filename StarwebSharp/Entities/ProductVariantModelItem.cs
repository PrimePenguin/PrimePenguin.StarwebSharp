using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVariantModelItem
    {
        [JsonProperty("data")]
        public ProductVariantModel Data { get; set; } = new ProductVariantModel();
    }
}
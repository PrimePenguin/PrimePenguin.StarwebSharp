using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVariantModelItem
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ProductVariantModel Data { get; set; } = new ProductVariantModel();
    }
}
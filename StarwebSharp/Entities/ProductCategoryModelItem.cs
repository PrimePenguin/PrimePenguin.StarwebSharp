using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductCategoryModelItem
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ProductCategoryModel Data { get; set; } = new ProductCategoryModel();
    }
}
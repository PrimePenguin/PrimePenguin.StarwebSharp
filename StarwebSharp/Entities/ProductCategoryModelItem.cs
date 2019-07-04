using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductCategoryModelItem
    {
        [JsonProperty("data")]
        public ProductCategoryModel Data { get; set; } = new ProductCategoryModel();
    }
}
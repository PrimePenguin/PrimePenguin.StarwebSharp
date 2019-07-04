using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductCategoryLinkModelItem
    {
        [JsonProperty("data")]
        public ProductCategoryLinkModel Data { get; set; } = new ProductCategoryLinkModel();
    }
}
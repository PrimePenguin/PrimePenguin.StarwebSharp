using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductCategoryLinkModelItem
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ProductCategoryLinkModel Data { get; set; } = new ProductCategoryLinkModel();
    }
}
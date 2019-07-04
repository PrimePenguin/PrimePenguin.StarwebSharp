using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductModelItem
    {
        [JsonProperty("data")]
        public ProductModel Data { get; set; } = new ProductModel();
    }
}
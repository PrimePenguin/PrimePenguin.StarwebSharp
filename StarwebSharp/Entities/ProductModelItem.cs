using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductModelItem
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ProductModel Data { get; set; } = new ProductModel();
    }
}
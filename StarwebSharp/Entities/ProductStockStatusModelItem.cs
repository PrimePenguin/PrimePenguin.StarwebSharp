using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductStockStatusModelItem
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ProductStockStatusModel Data { get; set; } = new ProductStockStatusModel();
    }
}
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductStockStatusModelItem
    {
        [JsonProperty("data")]
        public ProductStockStatusModel Data { get; set; } = new ProductStockStatusModel();
    }
}
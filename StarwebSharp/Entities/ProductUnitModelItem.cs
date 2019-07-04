using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductUnitModelItem
    {
        [JsonProperty("data")]
        public ProductUnitModel Data { get; set; } = new ProductUnitModel();
    }
}
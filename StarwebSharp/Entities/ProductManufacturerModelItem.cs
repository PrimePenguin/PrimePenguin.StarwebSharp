using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductManufacturerModelItem
    {
        [JsonProperty("data")]
        public ProductManufacturerModel Data { get; set; } = new ProductManufacturerModel();
    }
}
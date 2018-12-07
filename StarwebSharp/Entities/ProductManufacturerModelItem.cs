using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductManufacturerModelItem
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ProductManufacturerModel Data { get; set; } = new ProductManufacturerModel();
    }
}
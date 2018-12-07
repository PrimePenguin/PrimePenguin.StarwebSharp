using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductUnitModelItem
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ProductUnitModel Data { get; set; } = new ProductUnitModel();
    }
}
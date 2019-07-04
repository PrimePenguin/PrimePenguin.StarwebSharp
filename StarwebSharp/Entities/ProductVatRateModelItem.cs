using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVatRateModelItem
    {
        [JsonProperty("data")]
        public ProductVatRateModel Data { get; set; } = new ProductVatRateModel();
    }
}
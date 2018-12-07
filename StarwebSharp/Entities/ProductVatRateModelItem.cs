using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVatRateModelItem
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ProductVatRateModel Data { get; set; } = new ProductVatRateModel();
    }
}
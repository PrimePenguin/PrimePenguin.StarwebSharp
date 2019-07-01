using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVariantVolumePriceModelItem
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public ProductVariantVolumePriceModel Data { get; set; }
    }
}
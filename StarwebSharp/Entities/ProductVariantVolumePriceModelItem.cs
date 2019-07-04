using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVariantVolumePriceModelItem
    {
        [JsonProperty("data")]
        public ProductVariantVolumePriceModel Data { get; set; }
    }
}
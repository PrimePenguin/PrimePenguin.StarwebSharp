using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public partial class ProductVariantVolumePriceModelItem
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public ProductVariantVolumePriceModel Data { get; set; }


    }
}
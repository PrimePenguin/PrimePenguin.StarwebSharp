using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public partial class ProductBundleProductPriceModelItem
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public ProductBundleProductPriceModel Data { get; set; }


    }
}
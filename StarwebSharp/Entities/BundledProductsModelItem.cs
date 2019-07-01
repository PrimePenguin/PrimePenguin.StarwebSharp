using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public partial class BundledProductsModelItem
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public BundledProductsModel Data { get; set; }


    }
}
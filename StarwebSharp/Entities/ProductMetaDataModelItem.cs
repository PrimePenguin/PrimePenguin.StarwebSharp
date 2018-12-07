using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductMetaDataModelItem
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ProductMetaDataModel Data { get; set; } = new ProductMetaDataModel();
    }
}
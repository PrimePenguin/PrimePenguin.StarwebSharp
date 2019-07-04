using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductMetaDataModelItem
    {
        [JsonProperty("data")]
        public ProductMetaDataModel Data { get; set; } = new ProductMetaDataModel();
    }
}
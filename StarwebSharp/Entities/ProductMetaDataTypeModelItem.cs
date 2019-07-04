using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductMetaDataTypeModelItem
    {
        [JsonProperty("data")]
        public ProductMetaDataTypeModel Data { get; set; } = new ProductMetaDataTypeModel();
    }
}
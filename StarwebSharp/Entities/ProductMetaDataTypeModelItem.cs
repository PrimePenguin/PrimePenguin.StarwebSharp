using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductMetaDataTypeModelItem
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ProductMetaDataTypeModel Data { get; set; } = new ProductMetaDataTypeModel();
    }
}
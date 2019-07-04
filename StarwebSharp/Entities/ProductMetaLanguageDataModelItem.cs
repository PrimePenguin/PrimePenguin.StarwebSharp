using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductMetaLanguageDataModelItem
    {
        [JsonProperty("data")]
        public ProductMetaLanguageDataModel Data { get; set; } = new ProductMetaLanguageDataModel();
    }
}
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductMetaLanguageDataModelItem
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ProductMetaLanguageDataModel Data { get; set; } = new ProductMetaLanguageDataModel();
    }
}
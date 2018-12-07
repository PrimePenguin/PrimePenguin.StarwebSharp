using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductLanguageModelItem
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ProductLanguageModel Data { get; set; } = new ProductLanguageModel();
    }
}
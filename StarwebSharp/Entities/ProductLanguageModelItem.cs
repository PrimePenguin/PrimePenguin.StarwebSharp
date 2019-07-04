using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductLanguageModelItem
    {
        [JsonProperty("data")]
        public ProductLanguageModel Data { get; set; } = new ProductLanguageModel();
    }
}
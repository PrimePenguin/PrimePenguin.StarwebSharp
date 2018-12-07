using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductMediaFileLinkModelItem
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ProductMediaFileLinkModel Data { get; set; } = new ProductMediaFileLinkModel();
    }
}
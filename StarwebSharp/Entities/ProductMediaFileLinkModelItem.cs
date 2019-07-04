using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductMediaFileLinkModelItem
    {
        [JsonProperty("data")]
        public ProductMediaFileLinkModel Data { get; set; } = new ProductMediaFileLinkModel();
    }
}
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CustomerCreatedModelItem
    {
        [JsonProperty("data")]
        public CustomerCreatedModel Data { get; set; }
    }
}
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CustomerCreatedModelItem
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public CustomerCreatedModel Data { get; set; }
    }
}
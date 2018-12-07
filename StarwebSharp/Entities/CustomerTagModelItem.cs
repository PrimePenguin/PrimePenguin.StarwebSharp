using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CustomerTagModelItem
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public CustomerTagModel Data { get; set; } = new CustomerTagModel();
    }
}
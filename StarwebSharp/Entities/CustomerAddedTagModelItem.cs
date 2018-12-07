using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CustomerAddedTagModelItem
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public CustomerAddedTagModel Data { get; set; } = new CustomerAddedTagModel();
    }
}
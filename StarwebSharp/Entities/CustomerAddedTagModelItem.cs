using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CustomerAddedTagModelItem
    {
        [JsonProperty("data")]
        public CustomerAddedTagModel Data { get; set; } = new CustomerAddedTagModel();
    }
}
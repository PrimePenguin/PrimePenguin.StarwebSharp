using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CustomerTagModelItem
    {
        [JsonProperty("data")]
        public CustomerTagModel Data { get; set; } = new CustomerTagModel();
    }
}
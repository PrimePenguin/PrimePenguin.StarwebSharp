using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CustomerModelItem
    {
        [JsonProperty("data")]
        public CustomerModel Data { get; set; } = new CustomerModel();
    }
}
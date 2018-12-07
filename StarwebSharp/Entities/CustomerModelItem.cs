using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CustomerModelItem
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public CustomerModel Data { get; set; } = new CustomerModel();
    }
}
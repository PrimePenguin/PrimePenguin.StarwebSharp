using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CustomerExternalServicesModelItem
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public CustomerExternalServicesModel Data { get; set; } = new CustomerExternalServicesModel();
    }
}
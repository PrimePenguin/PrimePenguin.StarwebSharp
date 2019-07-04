using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CustomerExternalServicesModelItem
    {
        [JsonProperty("data")]
        public CustomerExternalServicesModel Data { get; set; } = new CustomerExternalServicesModel();
    }
}
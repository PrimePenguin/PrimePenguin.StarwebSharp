using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CustomerAddressesModelItem
    {
        [JsonProperty("data")]
        public AddressModel Data { get; set; } = new AddressModel();
    }
}
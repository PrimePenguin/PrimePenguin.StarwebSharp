using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CustomerAddressesModelItem
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public AddressModel Data { get; set; } = new AddressModel();
    }
}
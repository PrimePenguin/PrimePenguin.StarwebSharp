using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class Addresses
    {
        [JsonProperty("invoice", NullValueHandling = NullValueHandling.Ignore)]
        public AddressModel Invoice { get; set; } = new AddressModel();

        [JsonProperty("delivery", NullValueHandling = NullValueHandling.Ignore)]
        public AddressModel Delivery { get; set; } = new AddressModel();
    }
}
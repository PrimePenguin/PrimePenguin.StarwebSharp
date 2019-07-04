using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class Addresses
    {
        [JsonProperty("invoice")]
        public AddressModel Invoice { get; set; } = new AddressModel();

        [JsonProperty("delivery")]
        public AddressModel Delivery { get; set; } = new AddressModel();
    }
}
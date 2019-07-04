using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class Data
    {
        [JsonProperty("invoice")]
        public AddressModel Invoice { get; set; }

        [JsonProperty("delivery")]
        public AddressModel Delivery { get; set; }
    }
}
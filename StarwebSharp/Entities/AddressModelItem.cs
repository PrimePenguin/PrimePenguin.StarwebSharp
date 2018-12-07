using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class AddressModelItem
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public AddressModel Data { get; set; } = new AddressModel();
    }
}
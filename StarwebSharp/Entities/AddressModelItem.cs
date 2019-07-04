using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class AddressModelItem
    {
        [JsonProperty("data")]
        public AddressModel Data { get; set; } = new AddressModel();
    }
}
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ShippingTrackingTypeModel
    {
        /// <summary>The shipping tracking type ID</summary>
        [JsonProperty("type")]
        public int? Type { get; set; }

        /// <summary>The shipping tracking type name</summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
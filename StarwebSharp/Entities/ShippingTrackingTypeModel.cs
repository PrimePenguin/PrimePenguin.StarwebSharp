using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ShippingTrackingTypeModel
    {
        /// <summary>The shipping tracking type ID</summary>
        [JsonProperty("type",
            NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; }

        /// <summary>The shipping tracking type name</summary>
        [JsonProperty("name",
            NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }
}
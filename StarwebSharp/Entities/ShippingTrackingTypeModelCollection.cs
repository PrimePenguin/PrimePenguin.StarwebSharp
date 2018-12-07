using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ShippingTrackingTypeModelCollection
    {
        /// <summary>A list of shipping tracking types</summary>
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ShippingTrackingTypeModel> Data { get; set; } =
            new Collection<ShippingTrackingTypeModel>();
    }
}
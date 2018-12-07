using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class PricelistModelCollection
    {
        /// <summary>A collection of pricelists</summary>
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<PricelistModel> Data { get; set; } =
            new Collection<PricelistModel>();
    }
}
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ShippingMethodLanguageModelCollection
    {
        /// <summary>A collection of shipping method languages</summary>
        [JsonProperty("data")]
        public ICollection<ShippingMethodLanguageModel> Data { get; set; } =
            new Collection<ShippingMethodLanguageModel>();
    }
}
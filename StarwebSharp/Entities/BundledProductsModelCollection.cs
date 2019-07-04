using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class BundledProductsModelCollection
    {
        /// <summary>A collection of bundled products</summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<BundledProductsModel> Data { get; set; }
    }
}
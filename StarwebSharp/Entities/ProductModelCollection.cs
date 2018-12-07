using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductModelCollection
    {
        /// <summary>A collection of products</summary>
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ProductModel> Data { get; set; } =
            new Collection<ProductModel>();

        [JsonProperty("meta",
            NullValueHandling = NullValueHandling.Ignore)]
        public Meta Meta { get; set; } = new Meta();
    }
}
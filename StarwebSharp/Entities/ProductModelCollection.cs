using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductModelCollection
    {
        /// <summary>A collection of products</summary>
        [JsonProperty("data")]
        public ICollection<ProductModel> Data { get; set; } =
            new Collection<ProductModel>();

        [JsonProperty("meta")]
        public Meta Meta { get; set; } = new Meta();
    }
}
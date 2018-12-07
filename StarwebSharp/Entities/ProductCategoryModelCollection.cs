using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductCategoryModelCollection
    {
        /// <summary>A list of product categories</summary>
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ProductCategoryModel> Data { get; set; } =
            new Collection<ProductCategoryModel>();

        [JsonProperty("meta",
            NullValueHandling = NullValueHandling.Ignore)]
        public Meta Meta { get; set; } = new Meta();
    }
}
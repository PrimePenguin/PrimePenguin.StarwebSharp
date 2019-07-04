using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductCategoryModelCollection
    {
        /// <summary>A list of product categories</summary>
        [JsonProperty("data")]
        public ICollection<ProductCategoryModel> Data { get; set; } =
            new Collection<ProductCategoryModel>();

        [JsonProperty("meta")]
        public Meta Meta { get; set; } = new Meta();
    }
}
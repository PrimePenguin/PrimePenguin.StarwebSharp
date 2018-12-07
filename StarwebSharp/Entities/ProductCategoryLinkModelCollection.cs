using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductCategoryLinkModelCollection
    {
        /// <summary>A collection of product category links</summary>
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ProductCategoryLinkModel> Data { get; set; } =
            new Collection<ProductCategoryLinkModel>();
    }
}
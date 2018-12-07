using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductCategoryLinkModel
    {
        /// <summary>The category id this product should be listed in</summary>
        [JsonProperty("categoryId",
            NullValueHandling = NullValueHandling.Ignore)]
        public int CategoryId { get; set; }

        /// <summary>The sort index this product have in the category</summary>
        [JsonProperty("sortIndex",
            NullValueHandling = NullValueHandling.Ignore)]
        public int? SortIndex { get; set; }
    }
}
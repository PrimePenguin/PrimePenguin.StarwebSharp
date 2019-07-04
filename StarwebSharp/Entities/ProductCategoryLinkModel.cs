using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductCategoryLinkModel
    {
        /// <summary>The category id this product should be listed in</summary>
        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        /// <summary>The sort index this product have in the category</summary>
        [JsonProperty("sortIndex")]
        public int? SortIndex { get; set; }
    }
}
using Newtonsoft.Json;
using StarwebSharp.Infrastructure;

namespace StarwebSharp.Filters
{
    public class ProductCategoryFilter : Parameterizable
    {
        /// <summary>
        ///     Page of results to be returned. Default is 1.
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        ///     Use to fetch categories with a specific external id
        /// </summary>
        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        /// <summary>
        ///     Use to fetch only categories with this parentId
        /// </summary>
        [JsonProperty("parent")]
        public int? Parent { get; set; }

        /// <summary>
        ///     Only fetch categories visible to visitors. Default is false.
        /// </summary>
        [JsonProperty("filterVisible")]
        public bool FilterVisible { get; set; }

        /// <summary>
        ///     If you want to include child data in the result.
        ///     Example: ?include=languages (to include language based data such as category names, description, etc).
        ///     Available includes: languages
        /// </summary>
        [JsonProperty("include")]
        public string Include { get; set; }
    }
}
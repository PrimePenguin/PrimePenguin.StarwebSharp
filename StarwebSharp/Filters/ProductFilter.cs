using Newtonsoft.Json;
using StarwebSharp.Infrastructure;

namespace StarwebSharp.Filters
{
    public class ProductFilter : Parameterizable
    {
        /// <summary>
        ///     Page of results to be returned. Default is 1.
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        ///     Sort the result using a specified field. productId is default. Valid options are: productId
        /// </summary>
        [JsonProperty("sortBy")]
        public string SortBy { get; set; }

        /// <summary>
        ///     ASC for an ascending sort order; or DESC for a descending sort order. DESC is default
        ///     Available values : ASC, DESC
        /// </summary>
        [JsonProperty("sortOrder")]
        public string SortOrder { get; set; }

        /// <summary>
        ///     Use this to only fetch products that has been created since a certain time. The time should be formatted using
        ///     ISO-8601 (url encoded)
        /// </summary>
        [JsonProperty("createdSince")]
        public string CreatedSince { get; set; }

        /// <summary>
        ///     Use this to only fetch products that has been modified since a certain time. The time should be formatted using
        ///     ISO-8601 (url encoded)
        /// </summary>
        [JsonProperty("updatedSince")]
        public string UpdatedSince { get; set; }

        /// <summary>
        ///     Only fetch products visible to visitors. Default is false.
        /// </summary>
        [JsonProperty("filterVisible")]
        public bool FilterVisible { get; set; }

        /// <summary>
        ///     Only fetch a product with the specified SKU. Has to follow the pattern of /[A-Za-z0-9._-]+$/
        /// </summary>
        [JsonProperty("filterSku")]
        public string FilterSku { get; set; }

        /// <summary>
        ///     If you want to include child data in the result.
        ///     Example: ?include=primaryVariant (to include primary product variant);
        ///     ?include=primaryVariant,languages (to include both primary product variant and languages).
        ///     Available includes: primaryVariant, primaryVariant.prices, primaryVariant.attributeValues, attributes, mediaFiles,
        ///     languages, vatRates, categories, unit, metaData.
        ///     NOTE! Only one variant is included in result for performance reason.
        ///     To fetch all variants, instead use /products/x/variants(unnecessary if hasSeveralVariants is false)
        /// </summary>
        [JsonProperty("include")]
        public string Include { get; set; }
    }
}
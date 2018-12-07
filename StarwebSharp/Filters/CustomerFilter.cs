using Newtonsoft.Json;
using StarwebSharp.Infrastructure;

namespace StarwebSharp.Filters
{
    public class CustomerFilter : Parameterizable
    {
        /// <summary>
        /// Page of results to be returned. Default is 1.
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Sort the result using a specified field. customerId is default. Valid options are: customerId
        /// </summary>
        [JsonProperty("sortBy")]
        public string SortBy { get; set; }

        /// <summary>
        /// ASC for an ascending sort order; or DESC for a descending sort order. DESC is default
        /// Available values : ASC, DESC
        /// </summary>
        [JsonProperty("sortOrder")]
        public string SortOrder { get; set; }

        /// <summary>
        /// Use this to only fetch customers that has been created since a certain time. The time should be formatted using ISO-8601 (url encoded)
        /// </summary>
        [JsonProperty("createdSince")]
        public string CreatedSince { get; set; }

        /// <summary>
        /// Use this to only fetch customers that has been modified since a certain time. The time should be formatted using ISO-8601 (url encoded)
        /// </summary>
        [JsonProperty("updatedSince")]
        public string UpdatedSince { get; set; }

        /// <summary>
        /// Use this to also include customers without an account
        /// </summary>
        [JsonProperty("includeWithoutAccount")]
        public bool IncludeWithoutAccount { get; set; }

        /// <summary>
        /// If you want to include child data in the result.
        /// Example: ?include=tags (to include customer tags); ?include=tags,addresses (to include both customer tags and addresses).
        /// Available includes: tags, externalServices, addresses
        /// </summary>
        [JsonProperty("include")]
        public string Include { get; set; }
    }
}

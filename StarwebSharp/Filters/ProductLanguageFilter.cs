using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using StarwebSharp.Infrastructure;

namespace StarwebSharp.Filters
{
    public class ProductLanguageFilter: Parameterizable
    {
        /// <summary>
        /// Page of results to be returned. Default is 1.
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// If you want to include child data in the result.
        /// Example: ?include=prices (to include variants prices).
        /// Available includes: prices, attributes, attributes.attribute
        /// </summary>
        [JsonProperty("include")]

        public string Include { get; set; }
    }
}

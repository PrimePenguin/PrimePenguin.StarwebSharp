using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class PaginationModel
    {
        /// <summary>The current requested page</summary>
        [JsonProperty("current_page",
            NullValueHandling = NullValueHandling.Ignore)]
        public int? Current_page { get; set; }

        /// <summary>Number of items per page</summary>
        [JsonProperty("per_page",
            NullValueHandling = NullValueHandling.Ignore)]
        public int? Per_page { get; set; }

        /// <summary>The total number of items</summary>
        [JsonProperty("total",
            NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>Number of items on this page</summary>
        [JsonProperty("count",
            NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>Number of items on this page</summary>
        [JsonProperty("total_pages",
            NullValueHandling = NullValueHandling.Ignore)]
        public int? Total_pages { get; set; }
    }
}
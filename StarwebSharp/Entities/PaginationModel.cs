using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class PaginationModel
    {
        /// <summary>The current requested page</summary>
        [JsonProperty("current_page")]
        public int? Current_page { get; set; }

        /// <summary>Number of items per page</summary>
        [JsonProperty("per_page")]
        public int? Per_page { get; set; }

        /// <summary>The total number of items</summary>
        [JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>Number of items on this page</summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>Number of items on this page</summary>
        [JsonProperty("total_pages")]
        public int? Total_pages { get; set; }
    }
}
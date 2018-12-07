using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class Meta
    {
        [JsonProperty("pagination",
            NullValueHandling = NullValueHandling.Ignore)]
        public PaginationModel Pagination { get; set; } = new PaginationModel();
    }
}
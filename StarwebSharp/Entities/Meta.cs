using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class Meta
    {
        [JsonProperty("pagination")]
        public PaginationModel Pagination { get; set; } = new PaginationModel();
    }
}
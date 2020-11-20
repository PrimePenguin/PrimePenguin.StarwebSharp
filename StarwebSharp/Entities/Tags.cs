using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class Tags
    {
        [JsonProperty("data")]
        public Datum[] Data { get; set; }
    }

    public class Datum
    {
        [JsonProperty("tagId")]
        public long TagId { get; set; }

        [JsonProperty("tagOptionId")]
        public long TagOptionId { get; set; }

        [JsonProperty("links")]
        public EntityLink[] Links { get; set; }
    }
}
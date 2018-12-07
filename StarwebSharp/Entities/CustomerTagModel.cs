using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CustomerTagModel
    {
        /// <summary>The tag Id</summary>
        [JsonProperty("tagId",
            NullValueHandling = NullValueHandling.Ignore)]
        public int TagId { get; set; }

        /// <summary>The tag name</summary>
        [JsonProperty("name",
            NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }
}
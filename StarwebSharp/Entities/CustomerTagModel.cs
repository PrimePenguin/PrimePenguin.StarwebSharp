using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CustomerTagModel
    {
        /// <summary>The tag Id</summary>
        [JsonProperty("tagId")]
        public int TagId { get; set; }

        /// <summary>The tag name</summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
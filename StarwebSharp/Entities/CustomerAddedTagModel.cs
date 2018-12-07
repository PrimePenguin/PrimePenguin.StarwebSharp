using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CustomerAddedTagModel
    {
        /// <summary>The id of the tag</summary>
        [JsonProperty("tagId",
            NullValueHandling = NullValueHandling.Ignore)]
        [Range(1, int.MaxValue)]
        public int TagId { get; set; }

        /// <summary>The name of the tag</summary>
        [JsonProperty("name",
            NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }
}
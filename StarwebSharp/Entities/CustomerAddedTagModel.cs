using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CustomerAddedTagModel
    {
        /// <summary>The id of the tag</summary>
        [JsonProperty("tagId")]
        [Range(1, int.MaxValue)]
        public int TagId { get; set; }

        /// <summary>The name of the tag</summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
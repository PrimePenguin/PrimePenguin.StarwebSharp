using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductManufacturerModel
    {
        /// <summary>The id of this manufacturer</summary>
        [JsonProperty("manufacturerId")]
        public int? ManufacturerId { get; set; }

        /// <summary>The name of this manufacturer</summary>
        [JsonProperty("name")]
        
        [StringLength(30)]
        public string Name { get; set; }

        /// <summary>The URL to the manufacturers website</summary>
        [JsonProperty("url")]
        [StringLength(255)]
        public string Url { get; set; }

        /// <summary>The external id of this manufacturer</summary>
        [JsonProperty("externalId")]
        [StringLength(255)]
        public string ExternalId { get; set; }

        [JsonProperty("links")]
        public EntityLink[] Links { get; set; }
    }
}
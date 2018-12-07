using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductManufacturerModel
    {
        /// <summary>The id of this manufacturer</summary>
        [JsonProperty("manufacturerId",
            NullValueHandling = NullValueHandling.Ignore)]
        public int? ManufacturerId { get; set; }

        /// <summary>The name of this manufacturer</summary>
        [JsonProperty("name", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [StringLength(30)]
        public string Name { get; set; }

        /// <summary>The URL to the manufacturers website</summary>
        [JsonProperty("url",
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string Url { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductUnitModel
    {
        /// <summary>The units id</summary>
        [JsonProperty("unitId")]
        [Range(1, int.MaxValue)]
        public int UnitId { get; set; }

        /// <summary>The external Id</summary>
        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("externalIdType")]
        public string ExternalIdType { get; set; }

        [JsonProperty("languages")]
        public ProductUnitLanguageModelCollection Languages { get; set; }

        /// <summary>
        /// Product unit links
        /// </summary>
        [JsonProperty("links")]
        public EntityLink[] Links { get; set; }
    }
}
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

        [JsonProperty("languages")]
        public ProductUnitLanguageModelCollection Languages { get; set; }
    }
}
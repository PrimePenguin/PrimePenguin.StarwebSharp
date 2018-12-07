using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductUnitModel
    {
        /// <summary>The units id</summary>
        [JsonProperty("unitId",
            NullValueHandling = NullValueHandling.Ignore)]
        [Range(1, int.MaxValue)]
        public int UnitId { get; set; }

        [JsonProperty("languages",
            NullValueHandling = NullValueHandling.Ignore)]
        public ProductUnitLanguageModelCollection Languages { get; set; }
    }
}
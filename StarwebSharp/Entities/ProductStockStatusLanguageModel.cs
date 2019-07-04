using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductStockStatusLanguageModel
    {
        /// <summary>The stock status id</summary>
        [JsonProperty("stockStatusId")]
        public int? StockStatusId { get; set; }

        /// <summary>Language Code (ISO 639-1) for this translation. Has to be a valid lang code that the shop supports. </summary>
        [JsonProperty("langCode")]
        [StringLength(2, MinimumLength = 2)]
        public string LangCode { get; set; }

        /// <summary>The name of this stock status</summary>
        [JsonProperty("name")]
        [StringLength(40)]
        public string Name { get; set; }
    }
}
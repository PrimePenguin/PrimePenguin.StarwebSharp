using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderStatusLanguageModel
    {
        /// <summary>Language Code (ISO 639-1) for this translation. Has to be a valid lang code that the shop has setup. </summary>
        [JsonProperty("langCode")]
        [StringLength(2, MinimumLength = 2)]
        public string LangCode { get; set; }

        /// <summary>The name of this order status</summary>
        [JsonProperty("name")]
        [StringLength(64)]
        public string Name { get; set; }
    }
}
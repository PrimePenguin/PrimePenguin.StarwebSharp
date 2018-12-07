using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductMetaLanguageDataModel
    {
        /// <summary>The langCode for this language</summary>
        [JsonProperty("langCode",
            NullValueHandling = NullValueHandling.Ignore)]
        public string LangCode { get; set; }

        /// <summary>The value for this meta data</summary>
        [JsonProperty("value",
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string Value { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductMetaDataTypeLanguageModel
    {
        /// <summary>The language code for this language</summary>
        [JsonProperty("langCode")]
        public string LangCode { get; set; }

        /// <summary>The name of this meta data type</summary>
        [JsonProperty("name")]
        [StringLength(40)]
        public string Name { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductMetaDataTypeModel
    {
        /// <summary>The meta data type id</summary>
        [JsonProperty("metaDataTypeId",
            NullValueHandling = NullValueHandling.Ignore)]
        [Range(1, int.MaxValue)]
        public int MetaDataTypeId { get; set; }

        [JsonProperty("languages",
            NullValueHandling = NullValueHandling.Ignore)]
        public ProductMetaDataTypeLanguageModelCollection Languages { get; set; }
    }
}
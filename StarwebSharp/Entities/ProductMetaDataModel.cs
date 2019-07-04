using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductMetaDataModel
    {
        /// <summary>The ID of the meta data.</summary>
        [JsonProperty("metaDataId")]
        public int MetaDataId { get; set; }

        /// <summary>
        ///     The ID of the meta data type. Available meta data types can be fetched using the /product-meta-data-types
        ///     endpoint
        /// </summary>
        [JsonProperty("metaDataTypeId")]
        public int? MetaDataTypeId { get; set; }

        /// <summary>The sort index of this meta data for this product</summary>
        [JsonProperty("sortIndex")]
        public int? SortIndex { get; set; }

        [JsonProperty("languages")]
        public ProductMetaLanguageDataModelCollection Languages { get; set; }
    }
}
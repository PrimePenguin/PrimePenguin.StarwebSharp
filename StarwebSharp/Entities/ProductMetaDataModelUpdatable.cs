using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductMetaDataModelUpdatable
    {
        /// <summary>The ID of the meta data.</summary>
        [JsonProperty("metaDataId")]
        public int? MetaDataId { get; set; }

        /// <summary>
        ///     The ID of the meta data type. Available meta data types can be fetched using the /product-meta-data-types
        ///     endpoint
        /// </summary>
        [JsonProperty("metaDataTypeId")]
        public int? MetaDataTypeId { get; set; }

        /// <summary>The sort index of this meta data for this product</summary>
        [JsonProperty("sortIndex")]
        public int? SortIndex { get; set; }

        /// <summary>A collection of product meta data languages</summary>
        [JsonProperty("languages")]
        public ICollection<ProductMetaLanguageDataModel> Languages { get; set; } =
            new Collection<ProductMetaLanguageDataModel>();
    }
}
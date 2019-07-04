using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductMetaDataTypeModelCollection
    {
        /// <summary>A collection of product meta data types</summary>
        [JsonProperty("data")]
        public ICollection<ProductMetaDataTypeModel> Data { get; set; } =
            new Collection<ProductMetaDataTypeModel>();
    }
}
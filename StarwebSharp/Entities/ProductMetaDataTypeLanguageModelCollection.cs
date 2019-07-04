using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductMetaDataTypeLanguageModelCollection
    {
        /// <summary>A collection of product meta data type languages</summary>
        [JsonProperty("data")]
        public ICollection<ProductMetaDataTypeLanguageModel> Data { get; set; } =
            new Collection<ProductMetaDataTypeLanguageModel>();
    }
}
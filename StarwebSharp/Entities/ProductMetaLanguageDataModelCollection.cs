using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductMetaLanguageDataModelCollection
    {
        /// <summary>A collection of product meta data</summary>
        [JsonProperty("data")]
        public ICollection<ProductMetaLanguageDataModel> Data { get; set; } =
            new Collection<ProductMetaLanguageDataModel>();
    }
}
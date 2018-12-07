using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductMetaDataModelCollection
    {
        /// <summary>A collection of product meta data</summary>
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ProductMetaDataModel> Data { get; set; } =
            new Collection<ProductMetaDataModel>();
    }
}
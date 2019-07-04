using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductLanguageModelCollection
    {
        /// <summary>A collection of product languages</summary>
        [JsonProperty("data")]
        public ICollection<ProductLanguageModel> Data { get; set; } =
            new Collection<ProductLanguageModel>();
    }
}
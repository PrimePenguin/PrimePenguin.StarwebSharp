using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductUnitLanguageModelCollection
    {
        /// <summary>A collection of product unit languages</summary>
        [JsonProperty("data")]
        public ICollection<ProductUnitLanguageModel> Data { get; set; } =
            new Collection<ProductUnitLanguageModel>();
    }
}
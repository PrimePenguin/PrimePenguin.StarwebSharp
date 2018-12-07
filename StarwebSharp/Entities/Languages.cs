using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class Languages
    {
        /// <summary>A collection of product languages</summary>
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ProductLanguageSlimModel> Data { get; set; } =
            new Collection<ProductLanguageSlimModel>();
    }
}
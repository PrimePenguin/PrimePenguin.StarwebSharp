using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class Languages2
    {
        [JsonProperty("data")]
        public ICollection<ProductVariantAttributeLanguageModel> Data { get; set; } =
            new Collection<ProductVariantAttributeLanguageModel>();
    }
}
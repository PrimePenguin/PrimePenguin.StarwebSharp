using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductCategoryLanguagesModelCollection
    {
        /// <summary>A collection of category languages</summary>
        [JsonProperty("data")]
        public ICollection<ProductCategoryLanguagesModel> Data { get; set; } =
            new Collection<ProductCategoryLanguagesModel>();
    }
}
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductMediaFileLinkModelCollection
    {
        /// <summary>A collection of product media file links</summary>
        [JsonProperty("data")]
        public ICollection<ProductMediaFileLinkModel> Data { get; set; } =
            new Collection<ProductMediaFileLinkModel>();
    }
}
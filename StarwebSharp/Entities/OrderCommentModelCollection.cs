using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderCommentModelCollection
    {
        /// <summary>A list of order comments</summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OrderCommentModel> Data { get; set; }
    }
}
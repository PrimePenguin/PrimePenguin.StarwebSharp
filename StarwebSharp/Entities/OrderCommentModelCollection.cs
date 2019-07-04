using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderCommentModelCollection
    {
        /// <summary>A list of order comments</summary>
        [JsonProperty("data")]
        public ICollection<OrderCommentModel> Data { get; set; } =
            new Collection<OrderCommentModel>();
    }
}
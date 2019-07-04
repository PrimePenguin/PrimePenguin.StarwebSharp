using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CustomerTagModelCollection
    {
        /// <summary>A list of customer tags</summary>
        [JsonProperty("data")]
        public ICollection<CustomerTagModel> Data { get; set; } =
            new Collection<CustomerTagModel>();
    }
}
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CustomerAddedTagModelCollection
    {
        /// <summary>A list of customer tags</summary>
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomerAddedTagModel> Data { get; set; } =
            new Collection<CustomerAddedTagModel>();
    }
}
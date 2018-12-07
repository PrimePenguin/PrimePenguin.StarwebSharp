using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CustomerModelCollection
    {
        /// <summary>A list of customers</summary>
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomerModel> Data { get; set; } =
            new Collection<CustomerModel>();

        [JsonProperty("meta",
            NullValueHandling = NullValueHandling.Ignore)]
        public Meta Meta { get; set; } = new Meta();
    }
}
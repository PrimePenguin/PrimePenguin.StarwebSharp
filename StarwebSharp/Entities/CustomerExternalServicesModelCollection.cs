using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CustomerExternalServicesModelCollection
    {
        /// <summary>A list of customer external services</summary>
        [JsonProperty("data")]
        public ICollection<CustomerExternalServicesModel> Data { get; set; } =
            new Collection<CustomerExternalServicesModel>();
    }
}
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CustomerExternalServicesModel
    {
        /// <summary>The service name of the external service</summary>
        [JsonProperty("serviceName",
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(20)]
        public string ServiceName { get; set; }

        /// <summary>The external service ID</summary>
        [JsonProperty("externalIdValue",
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(40)]
        public string ExternalIdValue { get; set; }
    }
}
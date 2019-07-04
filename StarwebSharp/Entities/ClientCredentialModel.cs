using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ClientCredentialModel
    {
        /// <summary>The grant type to use for the request. At this time, only client_credentials is allowed</summary>
        [JsonProperty("grant_type")]
        public string Grant_type { get; set; }

        /// <summary>Your client id</summary>
        [JsonProperty("client_id")]
        public string Client_id { get; set; }

        /// <summary>Your client secret</summary>
        [JsonProperty("client_secret")]
        public string Client_secret { get; set; }
    }
}
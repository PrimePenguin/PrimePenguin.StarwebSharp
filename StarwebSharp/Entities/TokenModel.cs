using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class TokenModel
    {
        /// <summary>The Access Token to use in future requests</summary>
        [JsonProperty("access_token",
            NullValueHandling = NullValueHandling.Ignore)]
        public string AccessToken { get; set; }

        /// <summary>The scope this access token is valid for</summary>
        [JsonProperty("scope",
            NullValueHandling = NullValueHandling.Ignore)]
        public string Scope { get; set; }

        /// <summary>The number of seconds until this access token expires</summary>
        [JsonProperty("expires_in",
            NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpiresIn { get; set; }
    }
}
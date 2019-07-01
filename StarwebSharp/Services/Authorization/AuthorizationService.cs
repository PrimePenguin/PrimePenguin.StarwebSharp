using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using StarwebSharp.Entities;

namespace StarwebSharp.Services.Authorization
{
    /// <summary>
    ///     A service for getting auth tokens.
    /// </summary>
    public class AuthorizationService : StarwebService
    {
        /// <summary>
        ///     Creates a new instance of <see cref="AuthorizationService" />.
        /// </summary>
        /// <param name="myStarwebUrl">The shop's *.mystrweb.se/api/vX URL.</param>
        public AuthorizationService(string myStarwebUrl) : base(myStarwebUrl, null)
        {
        }

        /// <summary>
        ///     Retrieves the <see cref="TokenModel" />.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <returns>The <see cref="TokenModel" />.</returns>
        public virtual async Task<TokenModel> GetAuthTokenAsync(string clientId, string clientSecret)
        {
            var req = PrepareRequest("token");
            var content = new FormUrlEncodedContent(new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("grant_type", "client_credentials"),
                new KeyValuePair<string, string>("client_id", clientId),
                new KeyValuePair<string, string>("client_secret", clientSecret)
            });
            return await ExecuteRequestAsync<TokenModel>(req, HttpMethod.Post, content, "");
        }

        /// <summary>
        ///     Retrieves the <see cref="TokenModel" />.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecretPrefix"></param>
        /// <param name="clientSecret"></param>
        /// <returns>The <see cref="TokenModel" />.</returns>
        public virtual async Task<TokenModel> GetAuthTokenAsync(string clientId, string clientSecretPrefix,
            string clientSecret)
        {
            return await GetAuthTokenAsync(clientId, $"{clientSecretPrefix}{clientSecret}");
        }
    }
}
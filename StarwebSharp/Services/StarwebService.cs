using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StarwebSharp.Entities;
using StarwebSharp.Infrastructure;
using StarwebSharp.Infrastructure.Policies;

namespace StarwebSharp.Services
{
    public abstract class StarwebService
    {
        private static IRequestExecutionPolicy _GlobalExecutionPolicy = new DefaultRequestExecutionPolicy();

        private static JsonSerializer _Serializer = new JsonSerializer { DateParseHandling = DateParseHandling.DateTimeOffset };

        private static HttpClient _Client { get; } = new HttpClient();

        private IRequestExecutionPolicy _ExecutionPolicy;

        protected Uri _ShopUri { get; set; }

        protected string _AccessToken { get; set; }

        /// <summary>
        /// Creates a new instance of <see cref="StarwebService" />.
        /// </summary>
        /// <param name="myStarwebUrl">The shop's *.myStarweb.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        protected StarwebService(string myStarwebUrl, string shopAccessToken)
        {
            _ShopUri = BuildShopUri(myStarwebUrl);
            _AccessToken = shopAccessToken;

            // If there's a global execution policy it should be set as this instance's policy.
            // User can override it with instance-specific execution policy.
            _ExecutionPolicy = _GlobalExecutionPolicy ?? new DefaultRequestExecutionPolicy();
        }

        /// <summary>
        /// Attempts to build a shop API <see cref="Uri"/> for the given shop. Will throw a <see cref="StarwebException"/> if the URL cannot be formatted.
        /// </summary>
        /// <param name="myStarwebUrl">The shop's *.starwebserver.se URL.</param>
        /// <exception cref="StarwebException">Thrown if the given URL cannot be converted into a well-formed URI.</exception>
        /// <returns>The shop's API <see cref="Uri"/>.</returns>
        public static Uri BuildShopUri(string myStarwebUrl)
        {
            if (Uri.IsWellFormedUriString(myStarwebUrl, UriKind.Absolute) == false)
            {
                //Starweb typically returns the shop URL without a scheme. If the user is storing that as-is, the uri will not be well formed.
                //Try to fix that by adding a scheme and checking again.
                if (Uri.IsWellFormedUriString("https://" + myStarwebUrl, UriKind.Absolute) == false)
                {
                    throw new StarwebException($"The given {nameof(myStarwebUrl)} cannot be converted into a well-formed URI.");
                }

                myStarwebUrl = "https://" + myStarwebUrl;
            }

            var builder = new UriBuilder(myStarwebUrl)
            {
                Scheme = "https:",
                Port = 443 //SSL port
            };

            return builder.Uri;
        }

        /// <summary>
        /// Sets the execution policy for this instance only. This policy will always be used over the global execution policy.
        /// The instance will revert back to the global execution policy if you pass null to this method.
        /// </summary>
        public void SetExecutionPolicy(IRequestExecutionPolicy executionPolicy)
        {
            // If the user passes null, revert to the global execution policy.
            _ExecutionPolicy = executionPolicy ?? _GlobalExecutionPolicy ?? new DefaultRequestExecutionPolicy();
        }

        /// <summary>
        /// Sets the global execution policy for all *new* instances. Current instances are unaffected, but you can call .SetExecutionPolicy on them.
        /// </summary>
        public static void SetGlobalExecutionPolicy(IRequestExecutionPolicy globalExecutionPolicy)
        {
            _GlobalExecutionPolicy = globalExecutionPolicy;
        }

        protected RequestUri PrepareRequest(string path)
        {
            var ub = new UriBuilder(_ShopUri)
            {
                Scheme = "https:",
                Port = 443,
                Path = $"{_ShopUri.AbsolutePath}/{path}"
            };

            return new RequestUri(ub.Uri);
        }

        /// <summary>
        /// Prepares a request to the path and appends the shop's access token header if applicable.
        /// </summary>
        protected CloneableRequestMessage PrepareRequestMessage(RequestUri uri, HttpMethod method, HttpContent content = null)
        {
            var msg = new CloneableRequestMessage(uri.ToUri(), method, content);

            if (!string.IsNullOrEmpty(_AccessToken))
            {
                msg.Headers.Add("Authorization", $"Bearer {_AccessToken}");
            }

            msg.Headers.Add("Accept", "application/json");

            return msg;
        }

        /// <summary>
        /// Executes a request and returns a JToken for querying. Throws an exception when the response is invalid.
        /// Use this method when the expected response is a single line or simple object that doesn't warrant its own class.
        /// </summary>
        /// <remarks>
        /// This method will automatically dispose the <paramref name="baseClient"/> and <paramref name="content" /> when finished.
        /// </remarks>
        protected async Task<JToken> ExecuteRequestAsync(RequestUri uri, HttpMethod method, HttpContent content = null)
        {
            using (var baseRequestMessage = PrepareRequestMessage(uri, method, content))
            {
                var policyResult = await _ExecutionPolicy.Run(baseRequestMessage, async (requestMessage) =>
                {
                    var request = _Client.SendAsync(requestMessage);

                    using (var response = await request)
                    {
                        var rawResult = await response.Content.ReadAsStringAsync();

                        //Check for and throw exception when necessary.
                        CheckResponseExceptions(response, rawResult);

                        JToken jtoken = null;

                        // Don't parse the result when the request was Delete.
                        if (baseRequestMessage.Method != HttpMethod.Delete)
                        {
                            jtoken = JToken.Parse(rawResult);
                        }

                        return new RequestResult<JToken>(response, jtoken, rawResult);
                    }
                });

                return policyResult;
            }
        }

        /// <summary>
        /// Executes a request and returns the given type. Throws an exception when the response is invalid.
        /// Use this method when the expected response is a single line or simple object that doesn't warrant its own class.
        /// </summary>
        /// <remarks>
        /// This method will automatically dispose the <paramref name="baseRequestMessage" /> when finished.
        /// </remarks>
        protected async Task<T> ExecuteRequestAsync<T>(RequestUri uri, HttpMethod method, HttpContent content = null, string rootElement = null) where T : new()
        {
            using (var baseRequestMessage = PrepareRequestMessage(uri, method, content))
            {
                var policyResult = await _ExecutionPolicy.Run<T>(baseRequestMessage, async (requestMessage) =>
                {
                    var request = _Client.SendAsync(requestMessage);

                    using (var response = await request)
                    {
                        var rawResult = await response.Content.ReadAsStringAsync();

                        //Check for and throw exception when necessary.
                        CheckResponseExceptions(response, rawResult);

                        // This method may fail when the method was Delete, which is intendend.
                        // Delete methods should not be parsing the response JSON and should instead
                        // be using the non-generic ExecuteRequestAsync.
                        var reader = new JsonTextReader(new StringReader(rawResult));
                        var data = _Serializer.Deserialize<JObject>(reader).SelectToken(rootElement);
                        var result = data.ToObject<T>();

                        return new RequestResult<T>(response, result, rawResult);
                    }
                });

                return policyResult;
            }
        }

        /// <summary>
        /// Checks a response for exceptions or invalid status codes. Throws an exception when necessary.
        /// </summary>
        /// <param name="response">The response.</param>
        public static void CheckResponseExceptions(HttpResponseMessage response, string rawResponse)
        {
            int statusCode = (int)response.StatusCode;

            // No error if response was between 200 and 300.
            if (statusCode >= 200 && statusCode < 300)
            {
                return;
            }

            //var requestIdHeader = response.Headers.FirstOrDefault(h => h.Key.Equals("X-Request-Id", StringComparison.OrdinalIgnoreCase));
            //string requestId = requestIdHeader.Value?.FirstOrDefault();
            var code = response.StatusCode;

            // If the error was caused by reaching the API rate limit, throw a rate limit exception.
            //if ((int)code == 429 /* Too many requests */)
            //{
            //    string listMessage = "Exceeded 2 calls per second for api client. Reduce request rates to resume uninterrupted service.";
            //    string rateLimitMessage = $"Error: {listMessage}";

            //    // Starweb used to return JSON for rate limit exceptions, but then made an unannounced change and started returing HTML.
            //    // This dictionary is an attempt at preserving what was previously returned.
            //    var rateLimitErrors = new Dictionary<string, IEnumerable<string>>()
            //    {
            //        {"Error", new List<string>() {listMessage}}
            //    };

            //    throw new StarwebRateLimitException(code, rateLimitErrors, rateLimitMessage, rawResponse, requestId);
            //}

            var error = ParseErrorJson(rawResponse);
            string message = $"Response did not indicate success. Status: {(int)code} {response.ReasonPhrase}.";

            if (error == null)
            {
                throw new StarwebException(code, $"{(int)code} {response.ReasonPhrase}", message);
            }

            throw new StarwebException(code, error.Error, error.ErrorDescription);
        }

        /// <summary>
        /// Parses a JSON string for Starweb API errors.
        /// </summary>
        /// <returns>Returns null if the JSON could not be parsed into an error.</returns>
        public static ErrorModel ParseErrorJson(string json)
        {
            if (string.IsNullOrEmpty(json))
            {
                return null;
            }

            try
            {
                var parsed = JToken.Parse(string.IsNullOrEmpty(json) ? "{}" : json);

                if (parsed.Any(p => p.Path == "error") && parsed.Any(p => p.Path == "error_description"))
                {
                    // Error is type #4
                    var error = parsed["error"].Value<string>();
                    var description = parsed["error_description"].Value<string>();
                    return new ErrorModel(error, description);
                }
                return null;
            }
            catch (Exception e)
            {
                return new ErrorModel(e.Message, json);
            }
        }
    }
}

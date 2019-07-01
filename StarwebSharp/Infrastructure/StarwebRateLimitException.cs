using System.Net;

namespace StarwebSharp.Infrastructure
{
    /// <summary>
    ///     An exception thrown when an API call has reached StarWeb's rate limit.
    /// </summary>
    public class StarwebRateLimitException : StarwebException
    {
        public StarwebRateLimitException()
        {
        }

        public StarwebRateLimitException(string message) : base(message)
        {
        }

        public StarwebRateLimitException(HttpStatusCode httpStatusCode, string error, string jsonError) : base(
            httpStatusCode, error, jsonError)
        {
        }
    }
}
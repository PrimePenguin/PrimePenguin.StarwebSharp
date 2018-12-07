using System.Net.Http;

namespace StarwebSharp.Infrastructure
{
    public class RequestResult<T>
    {
        public HttpResponseMessage Response { get; }

        public T Result { get; }

        public string RawResult { get; }

        public RequestResult(HttpResponseMessage response, T result, string rawResult)
        {
            this.Response = response;
            this.Result = result;
            this.RawResult = rawResult;
        }
    }
}

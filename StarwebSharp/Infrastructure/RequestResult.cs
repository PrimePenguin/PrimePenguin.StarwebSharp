﻿using System.Net.Http;

namespace StarwebSharp.Infrastructure
{
    public class RequestResult<T>
    {
        public RequestResult(HttpResponseMessage response, T result, string rawResult)
        {
            Response = response;
            Result = result;
            RawResult = rawResult;
        }

        public HttpResponseMessage Response { get; }

        public T Result { get; }

        public string RawResult { get; }
    }
}
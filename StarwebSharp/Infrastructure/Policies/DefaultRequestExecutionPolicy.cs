﻿using System.Threading.Tasks;

namespace StarwebSharp.Infrastructure.Policies
{
    public class DefaultRequestExecutionPolicy : IRequestExecutionPolicy
    {
        public async Task<T> Run<T>(CloneableRequestMessage request, ExecuteRequestAsync<T> executeRequestAsync)
        {
            var fullResult = await executeRequestAsync(request);

            return fullResult.Result;
        }
    }
}
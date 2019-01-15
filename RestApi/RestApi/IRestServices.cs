using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestApi
{
    public interface IRestServices
    {
        // * Get Async API
        Task<List<TechItem>> CallGetAPI();
        Task<List<TechItem>> CallPostApi();
    }
}

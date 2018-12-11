using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestApi
{
    public class TechItemManager
    {
        IRestServices restServices;

        public TechItemManager(IRestServices services)
        {
            restServices = services;
        }

        public Task<List<TechItem>> GetAsyncData()
        {
            return restServices.CallGetAPI();
        }
    }
}

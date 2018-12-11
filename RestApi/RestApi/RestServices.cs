using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RestApi
{
    public class RestServices : IRestServices
    {
        HttpClient client;
        public List<TechItem> Items { get; private set; }

        public RestServices()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }

        public async Task<List<TechItem>> CallGetAPI()
        {
            Items = new List<TechItem>();

            var uri = new Uri(string.Format(Constants.APIUrl, string.Empty));

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Items = JsonConvert.DeserializeObject<List<TechItem>>(content);
                }
            }
            catch( Exception ex )
            {
                Debug.WriteLine("Error : {0}", ex.Message);
            }


            return Items;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
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

        public async Task<List<TechItem>> CallPostApi()
        {
            TechItem techItem = new TechItem();
            techItem.Id = 106;
            techItem.Name = ".NET";
            techItem.Language = "Microsoft";
            techItem.Rank = 7;
            techItem.TechFlag = true;

            Items = new List<TechItem>();
            var uri = new Uri(string.Format(Constants.POSTAPIUrl, string.Empty));
            var JSONRequest = JsonConvert.SerializeObject(techItem);

            var content = new StringContent(JSONRequest, Encoding.UTF8, "application/json");
            HttpResponseMessage response = null;

            try
            {
                client.DefaultRequestHeaders.Add("oauth", "638956");
                response = await client.PostAsync(uri, content);

                if (response.IsSuccessStatusCode)
                {
                    var JSONResponse = await response.Content.ReadAsStringAsync();
                    Items = JsonConvert.DeserializeObject<List<TechItem>>(JSONResponse);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR : {0}", ex.Message);
            }

            return Items;

        }

    }
     
}



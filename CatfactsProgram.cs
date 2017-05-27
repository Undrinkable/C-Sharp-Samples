using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace catfactsapp
{
    class CatfactsProgram
    {
        static HttpClient client = new HttpClient();

        static string urlParameteres = "?number=1";

        static void NotMain(string[] args)
        {
            RunAsync().Wait();
            Console.ReadKey();
        }
        static async Task RunAsync() {
            client.BaseAddress = new Uri("http://catfacts-api.appspot.com/api/facts");

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try {
                CatFacts catfacts = await GetCatFactsAsync();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            
        }

        static async Task<CatFacts> GetCatFactsAsync() {
            CatFacts facts = null;
            HttpResponseMessage response = client.GetAsync(urlParameteres).Result;
            if (response.IsSuccessStatusCode) {
                string data = await response.Content.ReadAsStringAsync();
                // JavaScriptSerializer serializer = new JavaScriptSerializer();
                // List<string> catfacts = serializer.Deserialize<List<string>>(data);
                // Console.WriteLine(catfacts);
                // facts = new CatFacts { Fact = catfacts[0]};
                Console.WriteLine(data);

            }
            return facts;
        }
    }

    class CatFacts {
        public string Fact { get; set; }
    }

}

using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace ChuckNorrisJokes.API.REST
{
    public static class RestAPI
    {
        //  Setting up the Http Client
        public static string BaseURL = "https://api.chucknorris.io/jokes/";
        public static async Task<T> GetAsync<T>(string path) where T: class
        {

            using (HttpClient client = new HttpClient())
            {
                T result = null;
                HttpResponseMessage response = await client.GetAsync(path);
                if (response != null)
                {
                    var resultString = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<T>(resultString);

                }
                return result;
            }
               
        }

    }
}

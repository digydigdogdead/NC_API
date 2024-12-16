using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace API
{
    internal static class APIMethods
    {
        private static string URL = "https://fakerapi.it/api/v1/books";
        internal static async Task<Response?> GetBooksAsync()
        {
            using (HttpClient httpClient = new())
            {
                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync(URL);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                    //Console.WriteLine(responseBody);

                    return JsonSerializer.Deserialize<Response>(responseBody);
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }
    }
}

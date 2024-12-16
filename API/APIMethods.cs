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
        
        internal static async Task<BookResponse?> GetBooksAsync(int quantity = 10, string locale = "en_US", int? seed = null)
        {
            string BASEURL = "https://fakerapi.it/api/v1/books";
            string URL = $"{BASEURL}?_quantity={quantity}&_locale={locale}"; if (seed != null) URL += $"&_seed={seed}";

            using (HttpClient httpClient = new())
            {
                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync(URL);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                    //Console.WriteLine(responseBody);

                    return JsonSerializer.Deserialize<BookResponse>(responseBody);
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }


        public static async Task<FlightResponse?> GetFlights() 
        {
            string app_id = "67bb4aee";
            string app_key = "baa2c9c89e13f6d12adf4a2ba7911662";

            using (HttpClient httpClient = new())
            {
                httpClient.DefaultRequestHeaders.Add("app_id", app_id);
                httpClient.DefaultRequestHeaders.Add("app_key", app_key);
                httpClient.DefaultRequestHeaders.Add("ResourceVersion", "v4");

                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync("https://api.schiphol.nl/public-flights/flights");
                    //response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseBody);

                    return JsonSerializer.Deserialize<FlightResponse>(responseBody);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }


        }



    }
}

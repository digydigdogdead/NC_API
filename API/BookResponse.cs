using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API
{
    internal class BookResponse
    {
        [JsonPropertyName("status")]
        public string Status {  get; set; }
        [JsonPropertyName("code")]
        public int Code { get; set; }
        [JsonPropertyName("total")]
        public int Total { get; set; } = 0;
        [JsonPropertyName("data")]
        public List<Book> Results { get; set; } = new List<Book>();
    }
}

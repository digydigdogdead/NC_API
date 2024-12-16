using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API
{
    internal class Book
    {
        [JsonPropertyName("id")]
        public int Id { get; set; } = 0;
        [JsonPropertyName("title")]
        public string Title { get; set; } = "";
        [JsonPropertyName("author")]
        public string Author { get; set; } = "";
        [JsonPropertyName("genre")]
        public string Genre { get; set; } = "";
        [JsonPropertyName("description")]
        public string Description { get; set; } = "";
        [JsonPropertyName("published")]
        public DateTime Published { get; set; }
        [JsonPropertyName("isbn")]
        public string ISBN { get; set; } = "";
        [JsonPropertyName("image")]
        public string ImageLink { get; set; } = "";
        [JsonPropertyName("publisher")]
        public string Publisher { get; set; } = "";
    }
}

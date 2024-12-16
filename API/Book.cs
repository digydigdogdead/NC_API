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
        [JsonPropertyName("firstname")]
        public string FirstName { get; set; } = "";
        [JsonPropertyName("lastname")]
        public string LastName { get; set; } = "";
        [JsonPropertyName("email")]
        public string Email { get; set; } = "";
        [JsonPropertyName("phone")]
        public string PhoneNumber { get; set; } = "";
        [JsonPropertyName("birthday")]
        public DateTime Birthday { get; set; }
    }
}

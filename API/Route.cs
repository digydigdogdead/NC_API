using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API
{
    internal class Route
    {
        [JsonPropertyName("destinations")]
        public List<string> Destinations { get; set; } = new List<string>();
        [JsonPropertyName("eu")]
        public char EU { get; set; } = '0';
        [JsonPropertyName("visa")]
        public bool Visa { get; set; } = false;
    }
}

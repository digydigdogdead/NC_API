using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API
{
    internal class FlightResponse
    {
        [JsonPropertyName("flights")]
        public List<Flight> FlightList { get; set; } = new List<Flight>();
        
    }
}

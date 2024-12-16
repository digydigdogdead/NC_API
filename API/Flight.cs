using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API
{
    internal class Flight
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = "";

        [JsonPropertyName("aircraftRegistration")]
        public string AircraftRegistration { get; set; } = "";

        [JsonPropertyName("flightName")]
        public string FlightName { get; set; } = "";

        [JsonPropertyName("flightDirection")]
        public char FlightDirection { get; set; } = '0';

        [JsonPropertyName("gate")]
        public string Gate { get; set; } = "";

        [JsonPropertyName("estimatedLandingTime")]
        public DateTime estimatedLandingTime { get; set; }

        [JsonPropertyName("actualLandingTime")]
        public DateTime actualLandingTime { get; set; }
        [JsonPropertyName("route")]
        public Route Route { get; set; } = new Route();

        public override string ToString()
        {
            if (FlightDirection == 'A')
            {
                return $"This flight arrived at {actualLandingTime.ToString()}, arriving at Gate {Gate}.";
            } else
            {
                return $"This flight arrived at {actualLandingTime.ToString()}, departing from Gate {Gate}.";
            }
        }
    }
}

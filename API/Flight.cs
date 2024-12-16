﻿using System;
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
        public int Id { get; set; } = 0;

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



    }
}
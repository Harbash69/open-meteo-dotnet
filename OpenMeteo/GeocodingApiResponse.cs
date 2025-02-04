﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace OpenMeteo
{
    /// <summary>
    /// Geocoding API response
    /// </summary>
    public class GeocodingApiResponse
    {
        /// <summary>
        /// Array of found locations
        /// </summary>
        [JsonPropertyName("results")]
        public LocationData[]? Locations { get; set; }

        /// <summary>
        /// Generation time of the weather forecast in milliseconds.
        /// </summary>
        public float Generationtime_ms { get; set; }
    }
}
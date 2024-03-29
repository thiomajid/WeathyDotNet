﻿using Newtonsoft.Json;

namespace WeathyDotNet.Responses;

public class Coordinates
{
    [JsonProperty("lon")]
    public double Longitude { get; set; }

    [JsonProperty("lat")]
    public double Latitude { get; set; }
}
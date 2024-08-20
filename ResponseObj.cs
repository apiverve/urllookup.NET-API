using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("range")]
    public string range { get; set; }

    [JsonProperty("country")]
    public string country { get; set; }

    [JsonProperty("region")]
    public string region { get; set; }

    [JsonProperty("city")]
    public string city { get; set; }

    [JsonProperty("timezone")]
    public string timezone { get; set; }

    [JsonProperty("state")]
    public string state { get; set; }

    [JsonProperty("zipcode")]
    public string zipcode { get; set; }

    [JsonProperty("coordinates")]
    public double[] coordinates { get; set; }

    [JsonProperty("url")]
    public string url { get; set; }

    [JsonProperty("domain")]
    public string domain { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}

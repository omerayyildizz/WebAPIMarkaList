using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebAPIMarkaList.Models;

public partial class Model
{
    [JsonProperty("Id")]
    public int Id { get; set; }
    [JsonProperty("ModelYear")]
    public string? ModelYear { get; set; }
    [JsonProperty("BrandName")]
    public string? BrandName { get; set; }
    [JsonProperty("BrandType")]
    public string? BrandType { get; set; }
    [JsonProperty("BrandCode")]
    public string? BrandCode { get; set; }
    [JsonProperty("Price")]
    public string? Price { get; set; }

}

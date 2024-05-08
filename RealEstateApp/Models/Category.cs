using Newtonsoft.Json;

namespace RealEstateApp.Models;

public class Category
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("image_url")]
    public string ImageUrl { get; set; }

    [JsonProperty("properties")]
    public object Properties { get; set; }
}

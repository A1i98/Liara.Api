namespace Liara.Api.Types;

public class Author
{
    [JsonProperty("email")] public string Email { get; set; }

    [JsonProperty("name")] public string Name { get; set; }
}
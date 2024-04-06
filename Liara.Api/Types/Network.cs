namespace Liara.Api.Types;

public class Network
{
    [JsonProperty("_id")] public string Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }
}
namespace Liara.Api.Types;

public class Node
{
    [JsonProperty("_id")] public string Id { get; set; }

    [JsonProperty("IP")] public string IP { get; set; }
}
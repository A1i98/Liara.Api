namespace Liara.Api.Types;

public class Storage
{
    [JsonProperty("namespace")] public string Namespace { get; set; }

    [JsonProperty("status")] public string Status { get; set; }
}
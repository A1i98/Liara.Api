namespace Liara.Api.Types;

public class Env
{
    [JsonProperty("key")] public string Key { get; set; }

    [JsonProperty("value")] public string Value { get; set; }

    [JsonProperty("encrypted")] public bool? Encrypted { get; set; }

    [JsonProperty("_id")] public string Id { get; set; }
}
namespace Liara.Api.Types;

public class Variable
{
    [JsonProperty("key")] public string Key { get; set; }

    [JsonProperty("value")] public string Value { get; set; }
}
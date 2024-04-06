namespace Liara.Api.Types;

public class Log
{
    [JsonProperty("type")] public string Type { get; set; }

    [JsonProperty("datetime")] public DateTime? Datetime { get; set; }

    [JsonProperty("message")] public string Message { get; set; }
}
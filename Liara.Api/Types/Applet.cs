namespace Liara.Api.Types;

public class Applet
{
    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("timestamp")] public string Timestamp { get; set; }

    [JsonProperty("state")] public string State { get; set; }

    [JsonProperty("reason")] public string Reason { get; set; }

    [JsonProperty("release")] public Release Release { get; set; }
}
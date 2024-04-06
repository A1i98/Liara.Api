namespace Liara.Api.Types;

public class AppRelease
{
    [JsonProperty("_id")] public string Id { get; set; }

    [JsonProperty("type")] public string Type { get; set; }

    [JsonProperty("imageName")] public string ImageName { get; set; }

    [JsonProperty("projectType")] public string ProjectType { get; set; }

    [JsonProperty("state")] public string State { get; set; }

    [JsonProperty("port")] public int? Port { get; set; }

    [JsonProperty("gitInfo")] public GitInfo GitInfo { get; set; }

    [JsonProperty("client")] public string Client { get; set; }

    [JsonProperty("finishedAt")] public string FinishedAt { get; set; }

    [JsonProperty("createdAt")] public string CreatedAt { get; set; }

    [JsonProperty("tag")] public string Tag { get; set; }

    [JsonProperty("sourceAvailable")] public bool? SourceAvailable { get; set; }
}
namespace Liara.Api.Types;

public class AppReleases
{
    [JsonProperty("total")] public int? Total { get; set; }

    [JsonProperty("currentRelease")] public string CurrentRelease { get; set; }

    [JsonProperty("readyReleasesCount")] public int? ReadyReleasesCount { get; set; }

    [JsonProperty("releases")] public List<AppRelease> Releases { get; set; }

    [JsonProperty("platform")] public string Platform { get; set; }
}
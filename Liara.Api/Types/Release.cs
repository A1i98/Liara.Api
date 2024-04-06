namespace Liara.Api.Types;

public class Release
{
    [JsonProperty("releaseID")] public string ReleaseID { get; set; }

    [JsonProperty("tag")] public string Tag { get; set; }
}
namespace Liara.Api.Types;

public class GitInfo
{
    [JsonProperty("branch")] public string Branch { get; set; }

    [JsonProperty("message")] public string Message { get; set; }

    [JsonProperty("commit")] public string Commit { get; set; }

    [JsonProperty("committedAt")] public string CommittedAt { get; set; }

    [JsonProperty("remote")] public string Remote { get; set; }

    [JsonProperty("author")] public Author Author { get; set; }

    [JsonProperty("tags")] public List<string> Tags { get; set; }
}
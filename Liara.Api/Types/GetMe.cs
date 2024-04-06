namespace Liara.Api.Types;

public class GetMe
{
    [JsonProperty("user")] public User? User { get; set; }

    [JsonProperty("databaseVersions")] public object? DatabaseVersions { get; set; }

    [JsonProperty("defaultDatabaseVersions")]
    public object? DefaultDatabaseVersions { get; set; }

    [JsonProperty("plans")] public Plans Plans { get; set; }
}
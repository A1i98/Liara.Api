namespace Liara.Api.Types;

public class Plans
{
    [JsonProperty("mail")] public object? Mail { get; set; }

    [JsonProperty("projects")] public object? Projects { get; set; }

    [JsonProperty("databases")] public object? Databases { get; set; }

    [JsonProperty("objectStorage")] public object? ObjectStorage { get; set; }

    [JsonProperty("legacyStorageService")] public object? LegacyStorageService { get; set; }
}
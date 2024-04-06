namespace Liara.Api.Types;

public class GetProject
{
    [JsonProperty("project")] public DetailProject Project { get; set; }
}
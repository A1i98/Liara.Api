namespace Liara.Api.Types;

public class GetProjects
{
    [JsonProperty("projects")] public List<Project>? ListOfProjects { get; set; }
}
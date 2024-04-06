namespace Liara.Api.Types;

public class UpdateEnvs
{
    [JsonProperty("project")] public string Project { get; set; }

    [JsonProperty("variables")] public List<Variable>? Variables { get; set; }
}
namespace Liara.Api.Types;

public class DetailProject
{
    [JsonProperty("_id")] public string Id { get; set; }

    [JsonProperty("project_id")] public string ProjectId { get; set; }

    [JsonProperty("type")] public string Type { get; set; }

    [JsonProperty("status")] public string Status { get; set; }

    [JsonProperty("defaultSubdomain")] public bool? DefaultSubdomain { get; set; }

    [JsonProperty("readOnlyRootFilesystem")]
    public bool? ReadOnlyRootFilesystem { get; set; }

    [JsonProperty("zeroDowntime")] public bool? ZeroDowntime { get; set; }

    [JsonProperty("scale")] public int? Scale { get; set; }

    [JsonProperty("envs")] public List<Env>? Envs { get; set; }

    [JsonProperty("planID")] public string PlanID { get; set; }

    [JsonProperty("fixedIPStatus")] public string FixedIPStatus { get; set; }

    [JsonProperty("created_at")] public string CreatedAt { get; set; }

    [JsonProperty("node")] public Node? Node { get; set; }

    [JsonProperty("hourlyPrice")] public double? HourlyPrice { get; set; }

    [JsonProperty("isDeployed")] public bool? IsDeployed { get; set; }

    [JsonProperty("reservedDiskSpace")] public int? ReservedDiskSpace { get; set; }

    [JsonProperty("network")] public Network? Network { get; set; }
}
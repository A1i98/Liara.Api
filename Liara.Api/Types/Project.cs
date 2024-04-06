namespace Liara.Api.Types;

public class Project
{
    [JsonProperty("_id")] public string Id { get; set; }

    [JsonProperty("project_id")] public string ProjectId { get; set; }

    [JsonProperty("type")] public string Type { get; set; }

    [JsonProperty("status")] public string Status { get; set; }

    [JsonProperty("scale")] public int? Scale { get; set; }

    [JsonProperty("planID")] public string PlanID { get; set; }

    [JsonProperty("network")] public Network Network { get; set; }

    [JsonProperty("created_at")] public DateTime? CreatedAt { get; set; }

    [JsonProperty("isDeployed")] public bool? IsDeployed { get; set; }
}
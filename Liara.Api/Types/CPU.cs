namespace Liara.Api.Types;

public class CPU
{
    [JsonProperty("amount")] public int? Amount { get; set; }

    [JsonProperty("shared")] public bool? Shared { get; set; }
}
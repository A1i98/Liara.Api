namespace Liara.Api.Types;

public class RAM
{
    [JsonProperty("amount")] public double? Amount { get; set; }

    [JsonProperty("shared")] public bool? Shared { get; set; }
}
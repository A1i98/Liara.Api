namespace Liara.Api.Types;

public class AppEvents
{
    [JsonProperty("data")] public List<Datum>? Data { get; set; }
}
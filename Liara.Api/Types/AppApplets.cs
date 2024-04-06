namespace Liara.Api.Types;

public class AppApplets
{
    [JsonProperty("applets")] public List<Applet>? Applets { get; set; }
}
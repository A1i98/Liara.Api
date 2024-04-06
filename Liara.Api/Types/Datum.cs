namespace Liara.Api.Types;

public class Datum
{
    [JsonProperty("metaData")] public object? MetaData { get; set; }

    [JsonProperty("values")] public List<List<string>>? Values { get; set; }
}
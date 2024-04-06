namespace Liara.Api;

public class LiaraOptions
{
    const string BaseLiaraUrl = "https://api.iran.liara.ir";

    public string? BaseUrl { get; }
    
    /// <summary>
    /// API token
    /// </summary>
    public string Token { get; }

    public LiaraOptions(string token, string? baseUrl = default)
    {
        Token = token ?? throw new ArgumentNullException(nameof(token));
        baseUrl ??= BaseUrl;

        BaseUrl = baseUrl ?? BaseLiaraUrl;
    }
}
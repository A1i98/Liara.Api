using System.Text;


namespace Liara.Api;

public partial class Liara
{
    readonly LiaraOptions _options;
    readonly HttpClient _httpClient;

    public Liara(
        LiaraOptions options,
        HttpClient? httpClient = default)
    {
        _options = options ?? throw new ArgumentNullException(nameof(options));
        _httpClient = httpClient ?? new HttpClient();
    }

    public Liara(
        string token,
        HttpClient? httpClient = null) :
        this(new LiaraOptions(token), httpClient)
    {
    }

    /// <summary>
    /// Get information about the current user.
    /// </summary>
    /// <returns>Returns the information about the current user.</returns>
    /// <remarks>This method sends a GET request to retrieve information about the current user.</remarks>
    public async Task<GetMe> GetMe()
    {
        return await SendRequest<GetMe>(_options.BaseUrl + "/v1/me", HttpMethod.Get);
    }

    public async Task<T> SendRequest<T>(string uri, HttpMethod method, Dictionary<string, object?>? parameters = null, object? body = null)
    {
        using var client = _httpClient;

        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _options.Token);

        HttpResponseMessage response;

        if (method == HttpMethod.Get)
        {
            response = await client.GetAsync(uri);
        }
        else if (method == HttpMethod.Post)
        {
            response = await SendPostRequest(client, uri, parameters ?? body);
        }
        else if (method == HttpMethod.Delete)
        {
            response = await client.DeleteAsync(uri);
        }
        else
        {
            throw new ArgumentException("Unsupported HTTP method");
        }

        response.EnsureSuccessStatusCode();

        var responseText = await response.Content.ReadAsStringAsync();

        var responseObject = JsonConvert.DeserializeObject<T>(responseText);
        return responseObject ?? throw new Exception(responseText);
    }

    public async Task<string> SendRequest(string uri, HttpMethod method, Dictionary<string, object?>? parameters = null)
    {
        using var client = _httpClient;

        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _options.Token);

        HttpResponseMessage response;

        if (method == HttpMethod.Get)
        {
            response = await client.GetAsync(uri);
        }
        else if (method == HttpMethod.Post)
        {
            response = await SendPostRequest(client, uri, parameters);
        }
        else if (method == HttpMethod.Delete)
        {
            response = await client.DeleteAsync(uri);
        }
        else
        {
            throw new ArgumentException("Unsupported HTTP method");
        }

        string responseBody = await response.Content.ReadAsStringAsync();
        return responseBody;
    }

    private async Task<HttpResponseMessage> SendPostRequest(HttpClient client, string uri, object? body)
    {
        var json = JsonConvert.SerializeObject(body);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        return await client.PostAsync(uri, content);
    }
}
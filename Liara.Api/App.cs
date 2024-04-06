namespace Liara.Api;

public partial class Liara 
{
     /// <summary>
    /// Retrieves a list of projects from the API.
    /// </summary>
    public async Task<GetProjects> GetApps()
    {
        return await SendRequest<GetProjects>(_options.BaseUrl + "/v1/projects", HttpMethod.Get);
    }

    /// <summary>
    /// Create app with the specified name, plan ID, platform, read-only root filesystem, and network.
    /// </summary>
    /// <param name="name">The name of the app.</param>
    /// <param name="planID">The ID of the plan for the app.</param>
    /// <param name="platform">The platform for the app.</param>
    /// <param name="readOnlyRootFilesystem">Whether the app has a read-only root filesystem.</param>
    /// <param name="network">The network for the app.</param>
    public async Task<string> CreateApp(string name, string planID, string platform, bool readOnlyRootFilesystem, string network)
    {
        var body = new Dictionary<string, object?>()
        {
            { "name", name },
            { "planID", planID },
            { "platform", platform },
            { "readOnlyRootFilesystem", readOnlyRootFilesystem },
            { "network", network }
        };
        return await SendRequest(_options.BaseUrl + "/v1/projects", HttpMethod.Post, body);
    }

    /// <summary>
    /// Gets a app by name.
    /// </summary>
    /// <param name="name">The name of the project to get.</param>
    public async Task<GetProject> GetAppByName(string name)
    {
        return await SendRequest<GetProject>(_options.BaseUrl + $"/v1/projects/{name}", HttpMethod.Get);
    }

    /// <summary>
    /// Deletes a app by name.
    /// </summary>
    /// <param name="name">The name of the app to delete.</param>
    public async Task<string> DeleteApp(string name)
    {
        return await SendRequest(_options.BaseUrl + $"/v1/projects/{name}", HttpMethod.Delete);
    }

    /// <summary>
    /// Enables or disables an app by scaling it up or down.
    /// </summary>
    /// <param name="name">The name of the app.</param>
    /// <param name="enable">True to enable the app, false to disable it.</param>
    public async Task<string> EnableApp(string name, bool enable)
    {
        var body = new Dictionary<string, object?>()
        {
            { "scale", enable ? 1 : 0 }
        };
        return await SendRequest(_options.BaseUrl + $"/v1/projects/{name}/actions/scale", HttpMethod.Post, body);
    }

    /// <summary>
    /// Restart the specified app.
    /// </summary>
    /// <param name="name">The name of the app to restart.</param>
    public async Task<string> RestartApp(string name)
    {
        return await SendRequest(_options.BaseUrl + $"/v1/projects/{name}/actions/restart", HttpMethod.Post);
    }

    /// <summary>
    /// Change an app with the specified name and planID.
    /// </summary>
    /// <param name="name">The name of the app to change.</param>
    /// <param name="planID">The ID of the plan to change the app to.</param>
    public async Task<string> ChangePlan(string name, string planID)
    {
        var body = new Dictionary<string, object?>()
        {
            { "planID", planID }
        };
        return await SendRequest(_options.BaseUrl + $"/v1/projects/{name}/resize", HttpMethod.Post, body);
    }

    /// <summary>
    /// Retrieves the application logs since a specified date.
    /// </summary>
    /// <param name="name">The name of the project.</param>
    /// <param name="since">The date and time since when to retrieve the logs.</param>
    public async Task<List<Log>> GetAppLogs(string name, DateTime since)
    {
        DateTimeOffset dateTimeOffset = new DateTimeOffset(since);
        long sinceUnix = dateTimeOffset.ToUnixTimeSeconds();
        return await SendRequest<List<Log>>(_options.BaseUrl + $"/v1/projects/{name}/logs?since={sinceUnix}", HttpMethod.Get);
    }

    /// <summary>
    /// Retrieves the application events for a specific project.
    /// </summary>
    /// <param name="name">The name of the project.</param>
    /// <param name="search">The search query for filtering events.</param>
    public async Task<AppEvents> GetAppEvents(string name, string search)
    {
        return await SendRequest<AppEvents>(_options.BaseUrl + $"/v1/projects/{name}/events?search={search}", HttpMethod.Get);
    }

    /// <summary>
    /// Get the app applets for a specific project by name.
    /// </summary>
    /// <param name="name">The name of the project to retrieve app applets for.</param>
    public async Task<AppApplets> GetAppApplets(string name)
    {
        return await SendRequest<AppApplets>(_options.BaseUrl + $"/v1/projects/{name}/applets", HttpMethod.Get);
    }

    /// <summary>
    /// Retrieves the releases of an app by name with optional pagination parameters.
    /// </summary>
    /// <param name="name">The name of the app.</param>
    /// <param name="page">The page number for pagination (default is 1).</param>
    /// <param name="count">The number of items per page for pagination (default is 10).</param>
    public async Task<AppReleases> GetAppReleases(string name, int page = 1, int count = 10)
    {
        return await SendRequest<AppReleases>(_options.BaseUrl + $"/v1/projects/{name}/releases?page={page}&count={count}", HttpMethod.Get);
    }
}
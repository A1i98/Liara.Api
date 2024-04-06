namespace Liara.Api;

public partial class Liara
{
    /// <summary>
    /// Performs a zero downtime operation on a specific project.
    /// </summary>
    /// <param name="id">The ID of the project.</param>
    /// <param name="status">The status of the zero downtime operation, can be "disable" or "enable".</param>
    public async Task<string> ZeroDowntime(string id, string status)
    {
        return await SendRequest(_options.BaseUrl + $"/v1/projects/{id}/zero-downtime/{status}", HttpMethod.Post);
    }
    
    /// <summary>
    /// Get the default subdomain for a project with the specified ID and status.
    /// </summary>
    /// <param name="id">The ID of the project.</param>
    /// <param name="status">The status of the default subdomain, can be "disable" or "enable".</param>
    public async Task<string> DefaultSubdomain(string id, string status)
    {
        return await SendRequest(_options.BaseUrl + $"/v1/projects/{id}/default-subdomain/{status}", HttpMethod.Post);
    }
    
    /// <summary>
    /// Changes the status of fixed IP for a specific project with zero downtime.
    /// </summary>
    /// <param name="id">The ID of the project.</param>
    /// <param name="status">The status to set for the fixed IP, can be "disable" or "enable".</param>
    public async Task<IpStatic> IpStatic(string id, string status)
    {
        return await SendRequest<IpStatic>(_options.BaseUrl + $"/v1/projects/{id}/fixed-ip/{status}", HttpMethod.Post);
    }
    
    public async Task<UpdateEnvsMessage> UpdateEnvs(UpdateEnvs updateEnvs) 
    {
        return await SendRequest<UpdateEnvsMessage>(_options.BaseUrl + $"/v1/projects/update-envs", HttpMethod.Post, body: updateEnvs);
    }
}
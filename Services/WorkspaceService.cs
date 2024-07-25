using KonnClient.Models;
using KonnClient.Services.Interfaces;

namespace KonnClient.Services;

public class WorkspaceService : IWorkspaceService
{
    private readonly HttpClient _httpClient;

    public WorkspaceService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public Task<bool> AddWorkspace(Workspace workspace)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteWorkspace(int workspaceId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Workspace>> GetAllWorkspaces()
    {
        throw new NotImplementedException();
    }

    public Task<Workspace?> GetUserWorkspace(int userId, int? workspaceId = null, string? workspaceName = null)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Workspace>> GetUserWorkspaces(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> HardDeleteWorkspace(int workspaceId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RestoreWorkspace(int workspaceId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateWorkspace(int workspaceId, Workspace workspace)
    {
        throw new NotImplementedException();
    }
}

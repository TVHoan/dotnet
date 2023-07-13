namespace dotnetbase.Permissions;

public interface IPermissionService
{
    Task<HashSet<string>> GetPermissionAsync(Guid memberId);
}
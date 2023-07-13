namespace dotnetbase.Models;

public class Permission
{
    public string Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
    public ICollection<Role> Roles { get; set; } = new List<Role>();
}
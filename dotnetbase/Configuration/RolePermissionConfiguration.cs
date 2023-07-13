using dotnetbase.Models;
using dotnetbase.Permissions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dotnetbase.Configuration;

internal sealed class RolePermissionConfiguration
    : IEntityTypeConfiguration<RolePermission>
{
    public void Configure(EntityTypeBuilder<RolePermission> builder)
    {
        builder.HasKey(x => new { x.RoleId, x.PermissionId });
        builder.HasOne<Permission>(x => x.Permission)
            .WithMany(x => x.RolePermissions);
        builder.HasOne<Role>(x => x.Role)
            .WithMany(x => x.RolePermissions);
        builder.HasData(RolePermissions());

    }

    private static IEnumerable<RolePermission> RolePermissions()
    {
        return typeof(PermissionDefine).GetFields()
            .Select(x => new RolePermission
            {
                RoleId = "2e98ddcb-d7cc-4ca3-9ec4-822e8cf6d9d5",
                PermissionId = x.Name
            });

    }
}
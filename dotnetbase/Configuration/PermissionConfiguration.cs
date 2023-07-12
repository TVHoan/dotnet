using dotnetbase.Models;
using dotnetbase.Permissions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dotnetbase.Configuration;

public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
{
    public void Configure(EntityTypeBuilder<Permission> builder)
    {
        builder.HasKey(p => p.Id);
        IEnumerable<Permission> permissions = typeof(PermissionDefine).GetFields()
            .Select(x => new Permission
            {
                Id = x.Name,
                Name = (string)x.GetRawConstantValue()
            });
        builder.HasData(permissions);
    }
    
}
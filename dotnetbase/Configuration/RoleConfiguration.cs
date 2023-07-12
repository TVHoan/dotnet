using dotnetbase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dotnetbase.Configuration;

internal class RoleConfiguration: IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {   
        builder.HasKey(x => x.Id);
        builder.HasMany(x => x.Permissions)
            .WithMany(x=>x)
            .UsingEntity<RolePermission>();
        builder.HasData(Role.Register);
    }
}
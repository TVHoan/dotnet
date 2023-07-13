using dotnetbase.Configuration;
using dotnetbase.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace dotnetbase.Data;

public class ApplicationDbContext : IdentityDbContext<IdentityUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    public DbSet<CategoryMenu> Categories { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Permission> Permissions { get; set; }
    public DbSet<RolePermission> RolePermissions { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
       new CategoryMenuConfiguration().Configure(modelBuilder.Entity<CategoryMenu>());
       new RoleConfiguration().Configure(modelBuilder.Entity<Role>());
       new PermissionConfiguration().Configure(modelBuilder.Entity<Permission>());
       new RolePermissionConfiguration().Configure(modelBuilder.Entity<RolePermission>());
    }
}
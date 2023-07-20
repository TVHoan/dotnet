using dotnetbase.Contracts;
using dotnetbase.Contracts.User;
using dotnetbase.Data;
using dotnetbase.Data.Seeding;
using dotnetbase.Permissions;
using dotnetbase.Repository;
using dotnetbase.Repository.User;

namespace dotnetbase.Dependency;

public static class Dependencyinjection
{
    public static void Add(IServiceCollection service)
    {   
        service.AddTransient(typeof(ISeeder),typeof(DataSeeder));
        service.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        service.AddScoped<IPermissionService, PermissionService>();
        
        // User
        service.AddScoped(typeof(IUserRepository), typeof(UserRepository));
    }
}
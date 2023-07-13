using dotnetbase.Data;
using dotnetbase.Permissions;
using dotnetbase.Repository;

namespace dotnetbase.dependency;

public static class Dependencyinjection
{
    public static void Add(IServiceCollection service)
    {
        service.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        service.AddScoped<IPermissionService, PermissionService>();
    }
}
using Microsoft.AspNetCore.Authorization;

namespace dotnetbase.Permissions;

public class PermissionAuthorizationHandler
    : AuthorizationHandler<PermissionRequirement>
{
    private readonly IServiceScopeFactory _serviceScopeFactory;

    public PermissionAuthorizationHandler(IServiceScopeFactory serviceScopeFactory)
    {
        _serviceScopeFactory = serviceScopeFactory;
    }

    protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement)
    {
        string? memberId= context.User.Claims.FirstOrDefault( )?.Value;
        if (!Guid.TryParse(memberId, out Guid parserMemberId))
        {
            return;
        }

        IServiceScope scope = _serviceScopeFactory.CreateScope();



        IPermissionService permissionService = scope.ServiceProvider
            .GetRequiredService<IPermissionService>();
        HashSet<string> permissions = await permissionService.GetPermissionAsync((parserMemberId));
        if (permissions.Contains(requirement.Permission))
        {
            context.Succeed(requirement);
        }
    }
}
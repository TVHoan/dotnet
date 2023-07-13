using Microsoft.AspNetCore.Authorization;

namespace dotnetbase.Permissions;

public class HasPermissionAttribute: AuthorizeAttribute
{
    public HasPermissionAttribute(string permission) : base(permission)
    {
        
    }
}
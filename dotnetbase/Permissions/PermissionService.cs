using dotnetbase.Data;
using dotnetbase.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetbase.Permissions;

public class PermissionService
    :IPermissionService
{
    private readonly ApplicationDbContext _context;

    public PermissionService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<HashSet<string>> GetPermissionAsync(Guid memberId)
    {
        Role[] roles = await _context.Set<ApplicationUser>()
            .Include(x => x.Role)
            .ThenInclude(x => x.Permissions)
            .Where(x => x.Id == memberId.ToString())
            .Select(x => x.Role)
            .ToArrayAsync();
        return roles
            .SelectMany(x => x.Permissions)
            .Select(x => x.Name)
            .ToHashSet();
    }
}
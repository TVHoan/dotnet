using dotnetbase.Models;
using Microsoft.AspNetCore.Identity;

namespace dotnetbase.Data.Seeding;

public class DataSeeder: ISeeder
{
    private readonly UserManager<IdentityUser> _userManager;

    public DataSeeder(UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        var admin = await _userManager.FindByNameAsync("admin");
        if (admin==null)
        {
            ApplicationUser user = new ApplicationUser
            {
                UserName = "admin",
                Email = "tranhoan.marketing@gmail.com",
                RoleId = "2e98ddcb-d7cc-4ca3-9ec4-822e8cf6d9d5"
            };
            await _userManager.CreateAsync(user, "Hoanhp97@");
        }
        
    }
}
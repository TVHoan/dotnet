using Microsoft.AspNetCore.Identity;

namespace dotnetbase.Models;

public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; }
    public byte[]? ProfilePicture { get; set; }
    public string? RoleId {get; set;}
    public Role Role {get; set;}
}
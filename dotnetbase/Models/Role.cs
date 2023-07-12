namespace dotnetbase.Models;

public sealed class Role 
{    public string Id { get; set; }
    public string Name { get; set; }
    public string DisplayName { get; set; }

    public static readonly Role Register = new Role("2e98ddcb-d7cc-4ca3-9ec4-822e8cf6d9d5", "admin","Admin");

    public Role(string id, string name,string displayName)
    {
        Id = id;
        Name = name;
        DisplayName = displayName;
    }

    public ICollection<Permission> Permissions { get; set; }
    public ICollection<ApplicationUser> Users { get; set; }
    
}
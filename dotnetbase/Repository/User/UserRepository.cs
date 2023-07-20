using dotnetbase.Contracts;
using dotnetbase.Contracts.User;
using dotnetbase.Data;
using dotnetbase.Models;

namespace dotnetbase.Repository.User;

public class UserRepository: Repository<ApplicationUser>,IUserRepository
{
    public UserRepository(ApplicationDbContext context) : base(context)
    {
    }
}
using Domain.Models;
using Domain.Repositories;

namespace Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    public Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<User> GetUserByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> GetAllUserAsync()
    {
        throw new NotImplementedException();
    }

    public Task CreateUserAsync(User user)
    {
        throw new NotImplementedException();
    }

    public void DeleteUser(User user)
    {
        throw new NotImplementedException();
    }
}
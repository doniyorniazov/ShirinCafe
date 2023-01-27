using Domain.Models;
namespace Domain.Repositories;

public interface IUserRepository
{
    Task SaveChangesAsync();
    
    Task<User> GetUserByIdAsync(int id);
    
    Task<IEnumerable<User>> GetAllUserAsync();

    Task CreateUserAsync(User user);

    void DeleteUser(User user);
}
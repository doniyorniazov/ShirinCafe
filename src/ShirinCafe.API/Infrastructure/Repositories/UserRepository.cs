using Domain.Models;
using Domain.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

    public async Task<User> GetUserByIdAsync(int id)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
    }

    public async Task<IEnumerable<User>> GetAllUserAsync()
    {
        return await _context.Users.ToListAsync();
    }

    public async Task CreateUserAsync(User user)
    {
        if (user is null)
            throw new ArgumentNullException(nameof(user));

        await _context.AddAsync(user);
    }

    public void DeleteUser(User user)
    {
        if (user is  null)
            throw new ArgumentNullException(nameof(user));
        
        _context.Users.Remove(user);
    }
}
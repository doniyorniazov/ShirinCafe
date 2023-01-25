using Microsoft.EntityFrameworkCore;
using ShirinCafe.API.Models;

namespace ShirinCafe.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
                
        }

        public DbSet<User> Users => Set<User>();
    }
}
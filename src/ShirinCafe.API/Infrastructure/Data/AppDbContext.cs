using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Food> Foods => Set<Food>();
    }
}
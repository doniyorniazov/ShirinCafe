using ShirinCafe.API.Models;
using ShirinCafe.API.Repositories.Abstractions;

namespace ShirinCafe.API.Infrastructure.Repositories;


public class FoodRepository : IFoodRepository
{
    public Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Food> GetFoodByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Food>> GetAllFoodsAsync()
    {
        throw new NotImplementedException();
    }

    public Task CreateFoodAsync(Food food)
    {
        throw new NotImplementedException();
    }

    public void DeleteFood(Food food)
    {
        throw new NotImplementedException();
    }
}
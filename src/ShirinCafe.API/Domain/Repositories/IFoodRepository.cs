using ShirinCafe.Domain.Repositories;

namespace ShirinCafe.API.Repositories.Abstractions;

public interface IFoodRepository
{
    Task SaveChangesAsync();

    Task<Food> GetFoodByIdAsync(int id);

    Task<IEnumerable<Food>> GetAllFoodsAsync();

    Task CreateFoodAsync(Food food);

    void DeleteFood(Food food);
}
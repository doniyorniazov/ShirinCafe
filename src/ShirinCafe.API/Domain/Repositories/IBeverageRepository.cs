using Domain.Models;

namespace Domain.Repositories;

public interface IBeverageRepository : IBaseRepository
{
    Task<Drink> CreateDrinkAsync();

    Task<Drink> GetDrinkById(int id);

    Task<IEnumerable<Drink>> GetAllDrinksAsync();

    Task<Drink> UpdateDrinkAsync(int id);

    void DeleteDrink(int id);
}
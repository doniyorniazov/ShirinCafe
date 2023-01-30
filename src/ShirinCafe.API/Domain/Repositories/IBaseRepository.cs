namespace Domain.Repositories;

public interface IBaseRepository
{
    Task SaveChangesAsync();
}
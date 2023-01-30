using Domain.Enums;

namespace Domain.Models;

public class Drink : BaseModel
{
    public string Name { get; set; }

    public string Description { get; set; }

    public Beverages Type { get; set; }

    public decimal Price { get; set; }
}
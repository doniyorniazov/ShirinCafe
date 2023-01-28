using Domain.Enums;

namespace Application.DataTransferObjects;

public class FoodDto
{
    public int Id { get; set; }
    
    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Ingredients { get; set; }

    public decimal Price { get; set; }

    public byte Image { get; set; }
    
    public FoodType Type { get; set; }
}
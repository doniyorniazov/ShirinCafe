using ShirinCafe.API.Application.Dtos;

namespace ShirinCafe.API.Dtos;

public class FoodDto
{
    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Ingredients { get; set; }

    public decimal Price { get; set; }

    public byte Image { get; set; }

    public FoodType Type { get; set; }
}
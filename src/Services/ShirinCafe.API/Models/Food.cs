namespace ShirinCafe.API.Models
{
    public class Food
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public FoodType Type { get; set; }
        public decimal Price { get; set; }
    }

    public enum FoodType
    {
        Breakfast,
        Salad,
        PideAndPizza,
        FastFood,
        Soup,
        Meat,
        Desert
    }
}
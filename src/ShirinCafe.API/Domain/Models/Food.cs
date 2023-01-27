using System.ComponentModel.DataAnnotations;
using Domain.Enums;

namespace Domain.Models;

    public class Food : BaseModel
    {
        [Required] public string? Name { get; set; }

        public string? Description { get; set; }

        [Required] public string? Ingredients { get; set; }

        [Required] public byte? Image { get; set; }

        [Required] public FoodType Type { get; set; }

        [Required] public decimal Price { get; set; }
    }

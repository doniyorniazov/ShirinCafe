using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class BaseModel
{
    [Key]
    public int Id { get; set; }
}
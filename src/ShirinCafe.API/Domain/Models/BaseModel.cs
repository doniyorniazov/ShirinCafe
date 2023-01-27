using System.ComponentModel.DataAnnotations;

namespace ShirinCafe.API.Domain.Models;

public class BaseModel
{
    [Key]
    public int Id { get; set; }
}
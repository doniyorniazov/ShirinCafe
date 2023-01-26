using System.ComponentModel.DataAnnotations;

namespace ShirinCafe.API.Models;

public class BaseModel
{
    [Key]
    public int Id { get; set; }
}
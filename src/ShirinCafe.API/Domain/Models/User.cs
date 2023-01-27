using System.ComponentModel.DataAnnotations;

namespace Domain.Models;
public class User : BaseModel
{
	[Required]
    public string? Name { get; set; }
    [Required]
    public string? Username { get; set; }
    [Required]
    public string? Password { get; set; }
    [Required]
    public string? Lastname { get; set; }
    [Required]
    public DateTime? BirthDate { get; set; }
    [Required]
    public string? Email { get; set; }       
}


namespace Application.DataTransferObjects;

public class UserUpdateDto
{
    public string? Name { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Lastname { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? Email { get; set; }    
}
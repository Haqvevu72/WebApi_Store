namespace Store.Domain.DTO.User;

public class ReadUserDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
    // public string Token { get; set; }
}
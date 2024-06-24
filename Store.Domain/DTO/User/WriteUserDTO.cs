namespace Store.Domain.DTO.User;

public class WriteUserDTO
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int RoleId{ get; set; }
}
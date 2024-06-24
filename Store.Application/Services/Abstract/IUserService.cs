using System.Net;
using Store.Domain.DTO.User;

namespace Store.Application.Services.Abstract;

public interface IUserService
{
    Task<ICollection<ReadUserDTO>> GetAllUsersAsync();
    Task<ReadUserDTO> GetUserByIdAsync(int userId);
    Task<HttpStatusCode> AddUserAsync(WriteUserDTO writeUserDto);
    Task<HttpStatusCode> UpdateUserAsync(int userId, WriteUserDTO writeUserDto);
    Task<HttpStatusCode> DeleteUserAsync(int userId);
}
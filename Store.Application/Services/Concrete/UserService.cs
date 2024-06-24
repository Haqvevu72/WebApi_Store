using System.Net;
using Store.Application.Services.Abstract;
using Store.Domain.DTO.User;
using Store.Domain.Entities.Concrete;
using Store.Domain.Repository_Interfaces.Role;
using Store.Domain.Repository_Interfaces.User;

namespace Store.Application.Services.Concrete;

public class UserService: IUserService
{
    private readonly IWriteUserRepository _writeUserRepository;
    private readonly IReadUserRepository _readUserRepository;
    private readonly IReadRoleRepository _readRoleRepository;
    
    public UserService(IWriteUserRepository writeUserRepository, IReadUserRepository readUserRepository, IReadRoleRepository readRoleRepository)
    {
        _writeUserRepository = writeUserRepository;
        _readUserRepository = readUserRepository;
        _readRoleRepository = readRoleRepository;
    }

    public async Task<ICollection<ReadUserDTO>> GetAllUsersAsync()
    {
        var users = await _readUserRepository.GetAllAsync();

        var usersDto = users.Where(u => !u.IsDeleted).Select(u => new ReadUserDTO()
        {
            Id = u.Id,
            Name = u.Name,
            Surname = u.Surname,
            Email = u.Email,
            Password = u.Password,
            Role = u.Role.RoleType.ToString(),
            // Token = u.Token.ToString()
        }).ToList();

        return usersDto;
    }

    public async Task<ReadUserDTO> GetUserByIdAsync(int userId)
    {
        var user = await _readUserRepository.GetByIdAsync(userId);

        if (user == null || user.IsDeleted)
            return null;

        var userDto = new ReadUserDTO()
        {
            Id = user.Id,
            Name = user.Name,
            Surname = user.Surname,
            Email = user.Email,
            Password = user.Password,
            Role = user.Role.RoleType.ToString(),
            // Token = user.Token.ToString()
        };

        return userDto;
    }

    public async Task<HttpStatusCode> AddUserAsync(WriteUserDTO writeUserDto)
    {
        var role = await _readRoleRepository.GetByIdAsync(writeUserDto.RoleId);

        if (role == null)
            return HttpStatusCode.NotFound;

        var user = new User()
        {
            Name = writeUserDto.Name,
            Surname = writeUserDto.Surname,
            Email = writeUserDto.Email,
            Password = writeUserDto.Password,
            RoleId = writeUserDto.RoleId
        };

        await _writeUserRepository.AddAsync(user);
        await _writeUserRepository.SaveChangeAsync();

        return HttpStatusCode.OK;
    }

    public async Task<HttpStatusCode> UpdateUserAsync(int userId, WriteUserDTO writeUserDto)
    {
        var user = await _readUserRepository.GetByIdAsync(userId);

        if (user == null)
            return HttpStatusCode.NotFound;
        
        var role = await _readRoleRepository.GetByIdAsync(writeUserDto.RoleId);

        if (role == null)
            return HttpStatusCode.NotFound;

        user.Name = writeUserDto.Name;
        user.Surname = writeUserDto.Surname;
        user.Email = writeUserDto.Email;
        user.Password = writeUserDto.Password;
        user.RoleId = writeUserDto.RoleId;

        await _writeUserRepository.UpdateAsync(user);
        await _writeUserRepository.SaveChangeAsync();

        return HttpStatusCode.OK;
    }

    public async Task<HttpStatusCode> DeleteUserAsync(int userId)
    {
        var user = await _readUserRepository.GetByIdAsync(userId);

        if (user == null)
            return HttpStatusCode.NotFound;

        user.IsDeleted = true;

        await _writeUserRepository.UpdateAsync(user);
        await _writeUserRepository.SaveChangeAsync();

        return HttpStatusCode.OK;
    }
}
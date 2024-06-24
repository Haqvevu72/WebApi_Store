using System.Net;
using Store.Application.Services.Abstract;
using Store.Domain;
using Store.Domain.DTO.Invoice;
using Store.Domain.DTO.Role;
using Store.Domain.Entities.Concrete;
using Store.Domain.Repository_Interfaces.Role;

namespace Store.Application.Services.Concrete;

public class RoleService: IRoleService
{
    private readonly IWriteRoleRepository _writeRoleRepository;
    private readonly IReadRoleRepository _readRoleRepository;

    public RoleService(IWriteRoleRepository writeRoleRepository, IReadRoleRepository readRoleRepository)
    {
        _writeRoleRepository = writeRoleRepository;
        _readRoleRepository = readRoleRepository;
    }

    public async Task<ICollection<ReadRoleDTO>> GetAllRolesAsync()
    {
        var roles = await _readRoleRepository.GetAllAsync();

        var rolesDto = roles.Where(r => !r.IsDeleted).Select(r => new ReadRoleDTO()
        {
            Id = r.Id,
            RoleType = Enum.GetName(typeof(RoleType),r.RoleType),
            Description = r.Description
        }).ToList();

        return rolesDto;
    }

    public async Task<ReadRoleDTO> GetRoleByIdAsync(int roleId)
    {
        var role = await _readRoleRepository.GetByIdAsync(roleId);

        if (role == null || role.IsDeleted)
            return null;

        var roleDto = new ReadRoleDTO()
        {
            Id = role.Id,
            RoleType = Enum.GetName(typeof(RoleType),role.RoleType),
            Description = role.Description
        };

        return roleDto;
    }

    public async Task<HttpStatusCode> AddRoleAsync(WriteRoleDTO writeRoleDto)
    {
        var role = new Role()
        {
            RoleType = (RoleType)Enum.Parse(typeof(RoleType), writeRoleDto.RoleType),
            Description = writeRoleDto.Description
        };

        await _writeRoleRepository.AddAsync(role);
        await _writeRoleRepository.SaveChangeAsync();

        return HttpStatusCode.OK;
    }

    public async Task<HttpStatusCode> UpdateRoleAsync(int roleId, WriteRoleDTO writeRoleDto)
    {
        var role = await _readRoleRepository.GetByIdAsync(roleId);

        if (role == null)
            return HttpStatusCode.NotFound;

        role.RoleType = (RoleType)Enum.Parse(typeof(RoleType), writeRoleDto.RoleType);
        role.Description = writeRoleDto.Description;

        await _writeRoleRepository.UpdateAsync(role);
        await _writeRoleRepository.SaveChangeAsync();

        return HttpStatusCode.OK;
    }

    public async Task<HttpStatusCode> DeleteRoleAsync(int roleId)
    {
        var role = await _readRoleRepository.GetByIdAsync(roleId);

        if (role == null)
            return HttpStatusCode.NotFound;

        role.IsDeleted = true;

        await _writeRoleRepository.UpdateAsync(role);
        await _writeRoleRepository.SaveChangeAsync();

        return HttpStatusCode.OK;
    }
}
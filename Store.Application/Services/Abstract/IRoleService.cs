using System.Net;
using Store.Domain.DTO.Invoice;
using Store.Domain.DTO.Role;

namespace Store.Application.Services.Abstract;

public interface IRoleService
{
    Task<ICollection<ReadRoleDTO>> GetAllRolesAsync();
    Task<ReadRoleDTO> GetRoleByIdAsync(int roleId);
    Task<HttpStatusCode> AddRoleAsync(WriteRoleDTO writeRoleDto);
    Task<HttpStatusCode> UpdateRoleAsync(int roleId,WriteRoleDTO writeInvoiceDto);
    Task<HttpStatusCode> DeleteRoleAsync(int roleId);
}
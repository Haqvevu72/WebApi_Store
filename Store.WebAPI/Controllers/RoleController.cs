using Microsoft.AspNetCore.Mvc;
using Store.Domain.Repository_Interfaces.Role;

namespace Store.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RoleController: ControllerBase
{

    private readonly IReadRoleRepository _readRoleRepository;
    public RoleController()
    {
        
    }
}
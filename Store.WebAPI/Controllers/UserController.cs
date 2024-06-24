using System.Net;
using Microsoft.AspNetCore.Mvc;
using Store.Application.Services.Abstract;
using Store.Domain.DTO.Category;
using Store.Domain.DTO.User;

namespace Store.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController: ControllerBase
{
    private readonly IUserService _userService;
    
    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("GetAllUsers")]
    public async Task<IActionResult> GetAllUsers()
    {
        var result = await _userService.GetAllUsersAsync();

        return Ok(result.ToList());
    }

    [HttpGet("GetUserById")]
    public async Task<IActionResult> GetUserById(int userId)
    {
        var result = await _userService.GetUserByIdAsync(userId);

        if (result == null)
            return NotFound();

        return Ok(result);
    }
    
    [HttpPost("AddUser")]
    public async Task<IActionResult> AddUser(WriteUserDTO writeUserDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        
        var result = await _userService.AddUserAsync(writeUserDto);

        if(result != HttpStatusCode.OK) 
            return BadRequest();

        return Ok(result);
    }

    [HttpPut("UpdateUser")]
    public async Task<IActionResult> UpdateUser(int userId, WriteUserDTO writeUserDto)
    { 
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        
        var result = await _userService.UpdateUserAsync(userId, writeUserDto);

        if(result != HttpStatusCode.OK) 
            return BadRequest();

        return Ok(result);
    }

    [HttpDelete("DeleteUser")]
    public async Task<HttpStatusCode> DeleteUser(int userId)
    {
        var result = await _userService.DeleteUserAsync(userId);

        return result;
    }
}
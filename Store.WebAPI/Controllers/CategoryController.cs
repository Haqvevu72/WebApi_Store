using System.Net;
using Microsoft.AspNetCore.Mvc;
using Store.Application.Services.Abstract;
using Store.Domain.DTO.Category;

namespace Store.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController: ControllerBase
{
    private readonly ICategoryService _categoryService;
    
    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet("GetAllCategories")]
    public async Task<IActionResult> GetAllCategories()
    {
        var result = await _categoryService.GetAllCategoriesAsync();

        return Ok(result);
    }

    [HttpGet("GetCategoryById")]
    public async Task<IActionResult> GetCategoryById(int categoryId)
    {
        var result = await _categoryService.GetCategoryById(categoryId);

        if (result == null)
            return NotFound();

        return Ok(result);
    }

    [HttpPost("AddCategory")]
    public async Task<IActionResult> AddCategory(WriteCategoryDTO writeCategoryDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        
        var result = await _categoryService.AddCategoryAsync(writeCategoryDto);
        
        if(result != HttpStatusCode.OK) 
            return BadRequest();

        return Ok(result);
    }

    [HttpPut("UpdateCategory")]
    public async Task<IActionResult> UpdateCategory(int categoryId, WriteCategoryDTO writeCategoryDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        
        var result = await _categoryService.UpdateCategoryAsync(categoryId, writeCategoryDto);

        if(result != HttpStatusCode.OK) 
            return BadRequest();

        return Ok(result);
    }

    [HttpDelete("DeleteCategory")]
    public async Task<HttpStatusCode> DeleteCategory(int categoryId)
    {
        var result = await _categoryService.DeleteCategoryAsync(categoryId);

        return result;
    }
}
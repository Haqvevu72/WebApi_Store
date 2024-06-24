using System.Net;
using Microsoft.AspNetCore.Mvc;
using Store.Application.Services.Abstract;
using Store.Domain.DTO.Product;

namespace Store.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController: ControllerBase
{
    private readonly IProductService _productService;
    
    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet("GetAllProducts")]
    public async Task<IActionResult> GetAllProducts()
    {
        var result = await _productService.GetAllProductsAsync();

        return Ok(result);
    }

    [HttpGet("GetProductId")]
    public async Task<IActionResult> GetProductById(int productId)
    {
        var result = await _productService.GetProductByIdAsync(productId);

        if (result == null)
            return NotFound();

        return Ok(result);
    }

    [HttpPost("AddProduct")]
    public async Task<IActionResult> AddProduct(WriteProductDTO writeProductDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        
        var result = await _productService.AddProductAsync(writeProductDto);

        if(result != HttpStatusCode.OK) 
            return BadRequest();

        return Ok(result);
    }

    [HttpPut("UpdateProduct")]
    public async Task<IActionResult> UpdateProduct(int productId, WriteProductDTO writeProductDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        
        var result = await _productService.UpdateProductAsync(productId, writeProductDto);

        if(result != HttpStatusCode.OK) 
            return BadRequest();

        return Ok(result);
        
    }

    [HttpDelete("DeleteProduct")]
    public async Task<HttpStatusCode> DeleteProduct(int productId)
    {
        var result = await _productService.DeleteProductAsync(productId);

        return result;
    }
}
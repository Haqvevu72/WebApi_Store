using System.Net;
using Microsoft.AspNetCore.Mvc;
using Store.Application.Services.Abstract;
using Store.Domain.DTO.Invoice;
using Store.Domain.DTO.Product;

namespace Store.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]

public class InvoiceController: ControllerBase
{
    private readonly IInvoiceService _invoiceService;
    
    public InvoiceController(IInvoiceService invoiceService)
    {
        _invoiceService = invoiceService;
    }
    
    [HttpGet("GetAllInvoices")]
    public async Task<IActionResult> GetAllInvoices()
    {
        var result = await _invoiceService.GetAllInvoicesAsync();

        return Ok(result);
    }

    [HttpGet("GetInvoiceById")]
    public async Task<IActionResult> GetInvoiceById(int invoiceId)
    {
        var result = await _invoiceService.GetInvoiceByIdAsync(invoiceId);

        if (result == null)
            return NotFound();

        return Ok(result);
    }

    [HttpPost("AddInvoice")]
    public async Task<IActionResult> AddInvoice(WriteInvoiceDTO writeInvoiceDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        
        var result = await _invoiceService.AddInvoiceAsync(writeInvoiceDto);

        if(result != HttpStatusCode.OK) 
            return BadRequest();

        return Ok(result);
    }

    [HttpPut("UpdateInvoice")]
    public async Task<IActionResult> UpdateInvoice(int invoiceId , WriteInvoiceDTO writeInvoiceDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        
        var result = await _invoiceService.UpdateInvoiceAsync(invoiceId, writeInvoiceDto);

        if(result != HttpStatusCode.OK) 
            return BadRequest();

        return Ok(result);
    }

    [HttpDelete("DeleteInvoice")]
    public async Task<HttpStatusCode> DeleteInvoice(int invoiceId)
    {
        var result = await _invoiceService.DeleteInvoiceAsync(invoiceId);

        return result;
    }
}
using System.Net;
using Store.Domain.DTO.Invoice;

namespace Store.Application.Services.Abstract;

public interface IInvoiceService
{
    Task<ICollection<ReadInvoiceDTO>> GetAllInvoicesAsync();
    Task<ReadInvoiceDTO> GetInvoiceByIdAsync(int invoiceId);
    Task<HttpStatusCode> AddInvoiceAsync(WriteInvoiceDTO writeInvoiceDto);
    Task<HttpStatusCode> UpdateInvoiceAsync(int invoiceId, WriteInvoiceDTO writeInvoiceDto);
    Task<HttpStatusCode> DeleteInvoiceAsync(int invoiceId);

}
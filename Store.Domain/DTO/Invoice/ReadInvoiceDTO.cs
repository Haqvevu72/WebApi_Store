using Store.Domain.DTO.InvoiceItem;

namespace Store.Domain.DTO.Invoice;

public class ReadInvoiceDTO
{
    public int Id { get; set; }
    public Guid QrCode { get; set; }
    public string InvoiceType { get; set; }
    public int CustomerId { get; set; }
    public int CashierId { get; set; }
    public  ICollection<ReadInvoiceItemDTO> InvoiceItems { get; set; }
}
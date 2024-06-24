using Store.Domain.DTO.InvoiceItem;

namespace Store.Domain.DTO.Invoice;

public class WriteInvoiceDTO
{
    public string InvoiceType { get; set; }
    public int CustomerId { get; set; }
    public int CashierId { get; set; }
    public  ICollection<WriteInvoiceItemDTO> InvoiceItems { get; set; }
}
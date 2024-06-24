namespace Store.Domain.DTO.InvoiceItem;

public class WriteInvoiceItemDTO
{
    public decimal Quantity { get; set; }
    public int ProductId { get; set; }
}
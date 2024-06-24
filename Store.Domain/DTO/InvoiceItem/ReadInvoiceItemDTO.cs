namespace Store.Domain.DTO.InvoiceItem;

public class ReadInvoiceItemDTO
{
    public int Id { get; set; }
    public decimal Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice { get; set; }
    public string Product { get; set; }
}
using Store.Domain.Entities.Abstract;

namespace Store.Domain.Entities.Concrete;

public class InvoiceItem: BaseEntity
{
    public decimal Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice => Quantity * UnitPrice;

    // Foreign Key
    public int ProductId { get; set; }
    
    // Navigation Properties
    public virtual Product Product { get; set; }
    
    public InvoiceItem(): base()
    {
    }
}
using Store.Domain.Entities.Abstract;

namespace Store.Domain.Entities.Concrete;

public class Invoice: BaseEntity
{
    public Guid QrCode { get; set; }
    public InvoiceType InvoiceType { get; set; }
    
    // Foreign Key
    public int CustomerId { get; set; }
    public int CashierId { get; set; }
    
    // Navigation Property
    public virtual ICollection<InvoiceItem> InvoiceItems { get; set; }
    public virtual User Customer { get; set; }
    public virtual User Cashier { get; set; }

    public Invoice(): base()
    {
        QrCode = Guid.NewGuid();
    }
}
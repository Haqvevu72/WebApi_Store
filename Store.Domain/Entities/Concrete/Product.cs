using Store.Domain.Entities.Abstract;

namespace Store.Domain.Entities.Concrete;

public class Product: BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public Guid BarCode { get; set; }
    public DateTime ExpireDate { get; set; }
    public string Brand { get; set; }
    
    // Foreign Key 
    public int CategoryId { get; set; }
    
    // Navigation Property
    public virtual Category Category { get; set; }
    public virtual ICollection<InvoiceItem> InvoiceItems { get; set; }

    public Product():base()
    {
        BarCode = Guid.NewGuid();
    }
}
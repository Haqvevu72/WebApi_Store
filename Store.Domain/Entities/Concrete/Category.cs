using Store.Domain.Entities.Abstract;

namespace Store.Domain.Entities.Concrete;

public class Category: BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    
    // Navigation Properties
    public virtual ICollection<Product> Products { get; set; }

    public Category(): base()
    {
        
    }
}
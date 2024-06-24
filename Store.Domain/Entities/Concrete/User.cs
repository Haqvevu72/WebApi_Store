using Store.Domain.Entities.Abstract;

namespace Store.Domain.Entities.Concrete;

public class User: BaseEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    
    // Foreign Key
    public int RoleId { get; set; }
    public int? TokenId { get; set; }
    
    // Navigation Property
    public virtual Role? Role { get; set; }
    public virtual UserToken? Token { get; set; }
    public virtual ICollection<Invoice>? CustomerInvoices { get; set; }
    public virtual ICollection<Invoice>? CashierInvoices { get; set; }

    public User(): base()
    {
        
    }
    
}
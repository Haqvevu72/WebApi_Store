using Store.Domain.Entities.Abstract;

namespace Store.Domain.Entities.Concrete;

public class UserToken: BaseEntity
{
    
    // Navigation Property
    public virtual User User { get; set; }
    public UserToken(): base()
    {
        
    }
}
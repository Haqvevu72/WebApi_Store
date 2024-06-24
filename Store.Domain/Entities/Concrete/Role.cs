using Store.Domain.Entities.Abstract;

namespace Store.Domain.Entities.Concrete;

public class Role: BaseEntity
{
    public RoleType RoleType { get; set; }
    public string Description { get; set; }
    
    // Navigation Property
    public virtual ICollection<User>? Users { get; set; }
    public Role(): base()
    {
        
    }
}
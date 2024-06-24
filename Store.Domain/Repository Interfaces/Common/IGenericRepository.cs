using Store.Domain.Entities.Abstract;

namespace Store.Domain.Repository_Interfaces;

public interface IGenericRepository<T> where T: BaseEntity,new()
{
    
}
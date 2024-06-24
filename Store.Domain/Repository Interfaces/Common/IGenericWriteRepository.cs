using System.Linq.Expressions;
using Store.Domain.Entities.Abstract;

namespace Store.Domain.Repository_Interfaces;

public interface IGenericWriteRepository<T>: IGenericRepository<T> where T : BaseEntity, new()
{
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(int id);
    Task DeleteAsync(T entity);
    Task SaveChangeAsync();
}
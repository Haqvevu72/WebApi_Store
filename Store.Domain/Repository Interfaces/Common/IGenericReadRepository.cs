using System.Linq.Expressions;
using Store.Domain.Entities.Abstract;

namespace Store.Domain.Repository_Interfaces;

public interface IGenericReadRepository<T>: IGenericRepository<T> where T : BaseEntity, new()
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<IQueryable<T>> GetByExpressionAsync(Expression<Func<T, bool>> expression);
    Task<T> GetByIdAsync(int id);
}
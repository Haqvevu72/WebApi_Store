using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Store.Domain.Entities.Abstract;
using Store.Domain.Repository_Interfaces;
using Store.Persistence.Database;

namespace Store.Persistence.Repository_Implementations;

public class ReadGenericRepository<T> : GenericRepository<T>, IGenericReadRepository<T> where T : BaseEntity, new()
{
    public ReadGenericRepository(StoreDb context) 
        : base(context)
    {
    }


    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return _table;
    }

    public async Task<IQueryable<T>> GetByExpressionAsync(Expression<Func<T, bool>> expression)
    {
        return _table.Where(expression);
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _table.FirstOrDefaultAsync(x => x.Id == id);
    }
}
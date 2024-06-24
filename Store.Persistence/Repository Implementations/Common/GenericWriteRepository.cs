using Microsoft.EntityFrameworkCore;
using Store.Domain.Entities.Abstract;
using Store.Domain.Repository_Interfaces;
using Store.Persistence.Database;

namespace Store.Persistence.Repository_Implementations;

public class WriteGenericRepository<T> : GenericRepository<T>, IGenericWriteRepository<T> where T : BaseEntity, new()
{
    public WriteGenericRepository(StoreDb context) :
        base(context)
    {
    }


    public async Task AddAsync(T entity)
    {
        await _table.AddAsync(entity);
    }
    
    public async Task DeleteAsync(int id)
    {
        var entity = await _table.FirstOrDefaultAsync(x => x.Id == id);
        if (entity != null)
            _table.Remove(entity);
    }

    public async Task DeleteAsync(T entity)
    {
        _table.Remove(entity);
    }

    public async Task SaveChangeAsync()
    {
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _table.Update(entity);
    }
}
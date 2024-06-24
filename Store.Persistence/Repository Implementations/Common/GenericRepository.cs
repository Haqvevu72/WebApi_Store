using Microsoft.EntityFrameworkCore;
using Store.Domain.Entities.Abstract;
using Store.Domain.Repository_Interfaces;
using Store.Persistence.Database;

namespace Store.Persistence.Repository_Implementations;

public class GenericRepository<T>:IGenericRepository<T> where T : BaseEntity, new()
{
    protected readonly StoreDb _context;
    protected DbSet<T> _table;
    
    public GenericRepository(StoreDb context)
    {
        _context = context;
        _table = context.Set<T>();
    }
}

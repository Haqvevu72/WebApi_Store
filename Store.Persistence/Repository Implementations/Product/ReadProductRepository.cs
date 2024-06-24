using Store.Domain.Entities.Concrete;
using Store.Domain.Repository_Interfaces.Product;
using Store.Persistence.Database;

namespace Store.Persistence.Repository_Implementations.Product;

public class ReadProductRepository: ReadGenericRepository<Domain.Entities.Concrete.Product> , IReadProductRepository
{
    public ReadProductRepository(StoreDb context) : base(context)
    {
    }
}
using Store.Domain.Repository_Interfaces.Product;
using Store.Persistence.Database;

namespace Store.Persistence.Repository_Implementations.Product;

public class WriteProductRepository: WriteGenericRepository<Domain.Entities.Concrete.Product> , IWriteProductRepository
{
    public WriteProductRepository(StoreDb context) : base(context)
    {
    }
}
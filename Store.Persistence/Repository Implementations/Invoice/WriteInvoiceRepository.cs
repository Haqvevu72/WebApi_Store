using Store.Domain.Repository_Interfaces.Invoice;
using Store.Persistence.Database;

namespace Store.Persistence.Repository_Implementations.Invoice;

public class WriteInvoiceRepository: WriteGenericRepository<Domain.Entities.Concrete.Invoice> , IWriteInvoiceRepository
{
    public WriteInvoiceRepository(StoreDb context) : base(context)
    {
    }
}
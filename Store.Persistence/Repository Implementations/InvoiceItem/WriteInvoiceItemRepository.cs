using Store.Domain.Repository_Interfaces.InvoiceItems;
using Store.Persistence.Database;

namespace Store.Persistence.Repository_Implementations.InvoiceItem;

public class WriteInvoiceItemRepository: WriteGenericRepository<Domain.Entities.Concrete.InvoiceItem>,IWriteInvoiceItemRepository
{
    public WriteInvoiceItemRepository(StoreDb context) : base(context)
    {
    }
}
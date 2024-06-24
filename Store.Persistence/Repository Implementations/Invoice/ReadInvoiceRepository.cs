using Store.Domain.Repository_Interfaces.Invoice;
using Store.Persistence.Database;

namespace Store.Persistence.Repository_Implementations.Invoice;

public class ReadInvoiceRepository: ReadGenericRepository<Domain.Entities.Concrete.Invoice> , IReadInvoiceRepository
{
    public ReadInvoiceRepository(StoreDb context) : base(context)
    {
    }
}
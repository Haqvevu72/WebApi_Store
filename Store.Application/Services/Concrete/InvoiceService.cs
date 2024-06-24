using System.Net;
using Store.Application.Services.Abstract;
using Store.Domain;
using Store.Domain.DTO.Invoice;
using Store.Domain.DTO.InvoiceItem;
using Store.Domain.Entities.Concrete;
using Store.Domain.Repository_Interfaces.Invoice;
using Store.Domain.Repository_Interfaces.Product;
using Store.Domain.Repository_Interfaces.User;

namespace Store.Application.Services.Concrete;

public class InvoiceService: IInvoiceService
{
    private readonly IWriteInvoiceRepository _writeInvoiceRepository;
    private readonly IReadInvoiceRepository _readInvoiceRepository;
    private readonly IReadUserRepository _readUserRepository;
    private readonly IReadProductRepository _readProductRepository;


    public InvoiceService(IWriteInvoiceRepository writeInvoiceRepository, IReadInvoiceRepository readInvoiceRepository, IReadUserRepository readUserRepository, IReadProductRepository readProductRepository)
    {
        _writeInvoiceRepository = writeInvoiceRepository;
        _readInvoiceRepository = readInvoiceRepository;
        _readUserRepository = readUserRepository;
        _readProductRepository = readProductRepository;
    }

    public async Task<ICollection<ReadInvoiceDTO>> GetAllInvoicesAsync()
    {
        var invoices = await _readInvoiceRepository.GetAllAsync();

        var invoicesDto = invoices.Where(i => !i.IsDeleted).Select(i => new ReadInvoiceDTO()
        {
            Id = i.Id,
            QrCode = i.QrCode,
            InvoiceType = i.InvoiceType.ToString(),
            CustomerId = i.CustomerId,
            CashierId = i.CashierId,
            InvoiceItems = i.InvoiceItems.Select(ii => new ReadInvoiceItemDTO()
            {
                Id = ii.Id,
                Quantity = ii.Quantity,
                UnitPrice = ii.UnitPrice,
                TotalPrice = ii.TotalPrice,
                Product = ii.Product.Name,

            }).ToList()
        }).ToList();

        return invoicesDto;
    }

    public async Task<ReadInvoiceDTO> GetInvoiceByIdAsync(int invoiceId)
    {
        var invoice = await _readInvoiceRepository.GetByIdAsync(invoiceId);

        if (invoice == null || invoice.IsDeleted)
            return null;

        var invoiceDto = new ReadInvoiceDTO()
        {
            Id = invoice.Id,
            QrCode = invoice.QrCode,
            InvoiceType = invoice.InvoiceType.ToString(),
            CustomerId = invoice.CustomerId,
            CashierId = invoice.CashierId,
            InvoiceItems = invoice.InvoiceItems.Select(ii => new ReadInvoiceItemDTO()
            {
                Id = ii.Id,
                Quantity = ii.Quantity,
                UnitPrice = ii.UnitPrice,
                TotalPrice = ii.TotalPrice,
                Product = ii.Product.Name,

            }).ToList()
        };

        return invoiceDto;

    }

    public async Task<HttpStatusCode> AddInvoiceAsync(WriteInvoiceDTO writeInvoiceDto)
    {
        var cashier = await _readUserRepository.GetByIdAsync(writeInvoiceDto.CashierId);
        if (cashier == null)
            return HttpStatusCode.NotFound;
        else if (cashier.RoleId != 3)
            return HttpStatusCode.NotAcceptable;

        var customer = await _readUserRepository.GetByIdAsync(writeInvoiceDto.CustomerId);
        if (customer == null)
            return HttpStatusCode.NotFound;
        else if (customer.RoleId != 4)
            return HttpStatusCode.NotAcceptable;
        
        var invoice = new Invoice()
        {
            InvoiceType = (InvoiceType)Enum.Parse(typeof(InvoiceType), writeInvoiceDto.InvoiceType),
            CashierId = writeInvoiceDto.CashierId,
            CustomerId = writeInvoiceDto.CustomerId,
            InvoiceItems = writeInvoiceDto.InvoiceItems.Select(ii => new InvoiceItem()
            {
                Quantity = ii.Quantity,
                ProductId = ii.ProductId,
                UnitPrice = _readProductRepository.GetByIdAsync(ii.ProductId).Result.Price
            }).ToList()
        };
        

        await _writeInvoiceRepository.AddAsync(invoice);
        await _writeInvoiceRepository.SaveChangeAsync();

        return HttpStatusCode.OK;
    }

    public async Task<HttpStatusCode> UpdateInvoiceAsync(int invoiceId, WriteInvoiceDTO writeInvoiceDto)
    {
        var invoice = await _readInvoiceRepository.GetByIdAsync(invoiceId);
        if (invoice == null)
            return HttpStatusCode.NotFound;

        var cashier = await _readUserRepository.GetByIdAsync(writeInvoiceDto.CashierId);
        if (cashier == null)
            return HttpStatusCode.NotFound;

        var customer = await _readUserRepository.GetByIdAsync(writeInvoiceDto.CustomerId);
        if (customer == null)
            return HttpStatusCode.NotFound;

        invoice.InvoiceType = (InvoiceType)Enum.Parse(typeof(InvoiceType), writeInvoiceDto.InvoiceType);
        invoice.CashierId = writeInvoiceDto.CashierId;
        invoice.CustomerId = writeInvoiceDto.CustomerId;
        invoice.InvoiceItems = writeInvoiceDto.InvoiceItems.Select(ii => new InvoiceItem()
        {
            Quantity = ii.Quantity,
            UnitPrice =_readProductRepository.GetByIdAsync(ii.ProductId).Result.Price,
            ProductId = ii.ProductId,
        }).ToList();

        await _writeInvoiceRepository.UpdateAsync(invoice);
        await _writeInvoiceRepository.SaveChangeAsync();

        return HttpStatusCode.OK;
    }

    public async Task<HttpStatusCode> DeleteInvoiceAsync(int invoiceId)
    {
        var invoice = await _readInvoiceRepository.GetByIdAsync(invoiceId);
        if (invoice == null)
            return HttpStatusCode.NotFound;

        invoice.IsDeleted = true;

        await _writeInvoiceRepository.UpdateAsync(invoice);
        await _writeInvoiceRepository.SaveChangeAsync();

        return HttpStatusCode.OK;
    }
}
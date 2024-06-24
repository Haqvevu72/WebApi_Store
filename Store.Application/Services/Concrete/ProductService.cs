using System.Net;
using Store.Application.Services.Abstract;
using Store.Domain.DTO.Product;
using Store.Domain.Entities.Concrete;
using Store.Domain.Repository_Interfaces.Category;
using Store.Domain.Repository_Interfaces.Product;

namespace Store.Application.Services.Concrete;

public class ProductService: IProductService
{
    private readonly IReadProductRepository _readProductRepository;
    private readonly IWriteProductRepository _writeProductRepository;
    private readonly IReadCategoryRepository _readCategoryRepository;

    public ProductService(IReadProductRepository readProductRepository, IWriteProductRepository writeProductRepository, IReadCategoryRepository readCategoryRepository)
    {
        _readProductRepository = readProductRepository;
        _writeProductRepository = writeProductRepository;
        _readCategoryRepository = readCategoryRepository;
    }

    
    public async Task<ICollection<ReadProductDTO>> GetAllProductsAsync()
    {
        var products = await _readProductRepository.GetAllAsync();

        var  allProductVm = products.Where(p => !p.IsDeleted).Select(p => new ReadProductDTO()
        {
            Id = p.Id,
            Name = p.Name,
            Description = p.Description,
            Price = p.Price,
            StockQuantity = p.StockQuantity,
            BarCode = p.BarCode,
            ExpireDate = p.ExpireDate,
            Brand = p.Brand,
            Category = p.Category.Name
        }).ToList();

        return allProductVm;
    }

    public async Task<ReadProductDTO?> GetProductByIdAsync(int productId)
    {
        var p = await _readProductRepository.GetByIdAsync(productId);

        if (p == null || p.IsDeleted)
            return null;

        var productVm = new ReadProductDTO()
        {
            Id = p.Id,
            Name = p.Name,
            Description = p.Description,
            Price = p.Price,
            StockQuantity = p.StockQuantity,
            BarCode = p.BarCode,
            ExpireDate = p.ExpireDate,
            Brand = p.Brand,
            Category = p.Category.Name
        };

        return productVm;
    }

    public async Task<HttpStatusCode> AddProductAsync(WriteProductDTO productVM)
    {
        var product = new Product()
        {
            Name = productVM.Name,
            Description = productVM.Description,
            Price = productVM.Price,
            StockQuantity = productVM.StockQuantity,
            ExpireDate = productVM.ExpireDate,
            Brand = productVM.Brand,
            CategoryId = productVM.CategoryId
        };

        await _writeProductRepository.AddAsync(product);
        await _writeProductRepository.SaveChangeAsync();

        return HttpStatusCode.OK;
    }

    public async Task<HttpStatusCode> UpdateProductAsync(int id, WriteProductDTO writeProductDTO)
    {
        var p = await _readProductRepository.GetByIdAsync(id);
        if (p == null)
            return HttpStatusCode.NotFound;

        var c = await _readCategoryRepository.GetByIdAsync(writeProductDTO.CategoryId);
        if (c == null)
            return HttpStatusCode.NotFound;

        p.Name = writeProductDTO.Name;
        p.Description = writeProductDTO.Description;
        p.Price = writeProductDTO.Price;
        p.StockQuantity = writeProductDTO.StockQuantity;
        p.ExpireDate = writeProductDTO.ExpireDate;
        p.Brand = writeProductDTO.Brand;
        p.CategoryId = writeProductDTO.CategoryId;

        await _writeProductRepository.UpdateAsync(p);
        await _writeProductRepository.SaveChangeAsync();

        return HttpStatusCode.OK;
    }

    public async Task<HttpStatusCode> DeleteProductAsync(int productId)
    {
        var p = await _readProductRepository.GetByIdAsync(productId);

        if (p == null)
            return HttpStatusCode.NotFound;

        p.IsDeleted = true;

        await _writeProductRepository.UpdateAsync(p);
        await _writeProductRepository.SaveChangeAsync();
        
        return HttpStatusCode.OK;
    }
}
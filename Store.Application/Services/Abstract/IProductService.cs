using System.Net;
using Store.Domain.DTO.Product;

namespace Store.Application.Services.Abstract;

public interface IProductService
{
    Task<ICollection<ReadProductDTO>> GetAllProductsAsync();
    Task<ReadProductDTO?> GetProductByIdAsync(int productId);
    Task<HttpStatusCode> AddProductAsync(WriteProductDTO productVM);
    Task<HttpStatusCode> UpdateProductAsync(int id,WriteProductDTO updateProductVM);
    Task<HttpStatusCode> DeleteProductAsync(int productId);
}
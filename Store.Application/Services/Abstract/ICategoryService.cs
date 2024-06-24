using System.Net;
using Store.Domain.DTO.Category;

namespace Store.Application.Services.Abstract;

public interface ICategoryService
{
    Task<ICollection<ReadCategoryDTO>> GetAllCategoriesAsync();
    Task<ReadCategoryDTO> GetCategoryById(int categoryId);
    Task<HttpStatusCode> AddCategoryAsync(WriteCategoryDTO writeCategoryDto);
    Task<HttpStatusCode> UpdateCategoryAsync(int categoryId, WriteCategoryDTO writeCategoryDto);
    Task<HttpStatusCode> DeleteCategoryAsync(int categoryId);
}
using System.Net;
using Store.Application.Services.Abstract;
using Store.Domain.DTO.Category;
using Store.Domain.Entities.Concrete;
using Store.Domain.Repository_Interfaces.Category;

namespace Store.Application.Services.Concrete;

public class CategoryService: ICategoryService
{
    private readonly IWriteCategoryRepository _writeCategoryRepository;
    private readonly IReadCategoryRepository _readCategoryRepository;
    
    public CategoryService(IWriteCategoryRepository writeCategoryRepository, IReadCategoryRepository readCategoryRepository)
    {
        _writeCategoryRepository = writeCategoryRepository;
        _readCategoryRepository = readCategoryRepository;
    }

    
    public async Task<ICollection<ReadCategoryDTO>> GetAllCategoriesAsync()
    {
        var categories = await _readCategoryRepository.GetAllAsync();

        var allcategoriesDtp = categories.Where(c => !c.IsDeleted).Select(c => new ReadCategoryDTO()
        {
            Id = c.Id,
            Name = c.Name,
            Description = c.Description
        }).ToList();

        return allcategoriesDtp;
    }

    public async Task<ReadCategoryDTO> GetCategoryById(int categoryId)
    {
        var category = await _readCategoryRepository.GetByIdAsync(categoryId);

        if (category == null || category.IsDeleted == true)
            return null;

        var categoryDto = new ReadCategoryDTO()
        {
            Id = category.Id,
            Name = category.Name,
            Description = category.Description
        };

        return categoryDto;
    }

    public async Task<HttpStatusCode> AddCategoryAsync(WriteCategoryDTO writeCategoryDto)
    {
        var newCategory = new Category()
        {
            Name = writeCategoryDto.Name,
            Description = writeCategoryDto.Description
        };

        await _writeCategoryRepository.AddAsync(newCategory);
        await _writeCategoryRepository.SaveChangeAsync();

        return HttpStatusCode.OK;
    }

    public async Task<HttpStatusCode> UpdateCategoryAsync(int categoryId, WriteCategoryDTO writeCategoryDto)
    {
        var category = await _readCategoryRepository.GetByIdAsync(categoryId);

        if (category == null)
            return HttpStatusCode.NotFound;

        category.Name = writeCategoryDto.Name;
        category.Description = writeCategoryDto.Description;

        await _writeCategoryRepository.UpdateAsync(category);
        await _writeCategoryRepository.SaveChangeAsync();

        return HttpStatusCode.OK;
    }

    public async Task<HttpStatusCode> DeleteCategoryAsync(int categoryId)
    {
        var category = await _readCategoryRepository.GetByIdAsync(categoryId);

        if (category == null)
            return HttpStatusCode.NotFound;

        category.IsDeleted = true;

        await _writeCategoryRepository.UpdateAsync(category);
        await _writeCategoryRepository.SaveChangeAsync();

        return HttpStatusCode.OK;
    }
}
using FormationEcommerce.Application.Categories.Dtos;

namespace FormationEcommerce.Application.Categories.Interfaces
{
    public interface ICategoryService
    {
        Task<CategoryDto> AddCategoryServiceAsync(CreateCategoryDto createCategoryDto);

        Task<CategoryDto> GetCategoryByIdServiceAsync(Guid id);

        Task<Guid> GetCategoryIdByCategoryNameServiceAsync(string categoryName);

        Task<IEnumerable<CategoryDto>> GetAllCategoriesServiceAsync();

        Task UpdateCategoryServiceAsync(UpdateCategoryDto updateCategoryDto);

        Task DeleteCategoryServiceAsync(Guid id);
    }
}
using FormationEcommerce.Core.Entities.Categories;
using FormationEcommerce.Core.Interfaces.Repositories.Base;

namespace FormationEcommerce.Core.Interfaces.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        //redundancy
        /*
        Task<Category> AddCategoryAsync(Category category);

        Task UpdateCategoryAsync(Category category);

        Task DeleteCategoryAsync(Guid categoryId);

        Task<Category> GetCategoryByIdAsync(Guid id);

        Task<IEnumerable<Category>> GetAllCategoriesAsync();*/

        Task<Guid> GetCategoryIdByCategoryNameAsync(string categoryName);
    }
}
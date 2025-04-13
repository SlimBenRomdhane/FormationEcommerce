using FormationEcommerce.Core.Entities.Categories;
using FormationEcommerce.Core.Interfaces.Repositories;
using FormationEcommerce.Infrastructure.Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace FormationEcommerce.Infrastructure.Persistence.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> GetCategoryIdByCategoryNameAsync(string categoryName)
        {
            var category = await _dbContext.Categories.FirstOrDefaultAsync(c => c.Name == categoryName);
            if (category == null)
            {
                throw new Exception($"Category with name {categoryName} not found.");
            }
            return category.Id;
        }
    }
}
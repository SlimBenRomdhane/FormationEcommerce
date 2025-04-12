using FormationEcommerce.Core.Entities.Products;
using FormationEcommerce.Core.Interfaces.Repositories.Base;

namespace FormationEcommerce.Core.Interfaces.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> AddProductAsync(Product product);

        Task<IEnumerable<Product>> GetAllProductsAsync();

        Task<Product?> GetProductByIdAsync(Guid productId);

        Task<bool> UpdateProductAsync(Product product);

        Task<bool> DeleteProductAsync(Guid productId);
    }
}
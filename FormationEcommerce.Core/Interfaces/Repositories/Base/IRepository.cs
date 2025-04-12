namespace FormationEcommerce.Core.Interfaces.Repositories.Base
{
    public interface IRepository<T> where T : class
    {
        Task<T> AddAsyncGeneric(T entity);

        Task UpdateAsyncGeneric(T entity);

        Task DeleteAsyncGeneric(T entity);

        Task<T> GetByIdAsyncGeneric(Guid id);

        Task<IEnumerable<T>> GetAllAsyncGeneric();

        Task<int> SaveChangesAsyncGeneric();
    }
}
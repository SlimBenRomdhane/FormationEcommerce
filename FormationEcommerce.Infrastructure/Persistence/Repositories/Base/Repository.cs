using FormationEcommerce.Core.Interfaces.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace FormationEcommerce.Infrastructure.Persistence.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<T> AddAsyncGeneric(T entity)
        {
            await _dbSet.AddAsync(entity);
            return entity;
        }

        public async Task DeleteAsyncGeneric(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsyncGeneric()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsyncGeneric(Guid id)
        {
            //return await _dbSet.FindAsync(id);

            /*For the generic entity e,
            dynamically access the property named "Id" (as a Guid) and compare its value to id.
            Return the entity if the property matches the value."*/

            return await _dbSet.FirstOrDefaultAsync(e => EF.Property<Guid>(e, "Id") == id);
        }

        public async Task UpdateAsyncGeneric(T entity)
        {
            _dbSet.Update(entity);
        }

        public async Task<int> SaveChangesAsyncGeneric()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
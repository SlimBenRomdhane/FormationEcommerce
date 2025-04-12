using FormationEcommerce.Core.Interfaces.Repositories;
using FormationEcommerce.Core.Interfaces.Repositories.Base;
using FormationEcommerce.Infrastructure.Persistence;
using FormationEcommerce.Infrastructure.Persistence.Repositories;
using FormationEcommerce.Infrastructure.Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FormationEcommerce.Infrastructure.Extension
{
    public static class InfrastructureRegistration
    {
        public static IServiceCollection AddInfrastructureServicesRegistration(this IServiceCollection services,
            IConfiguration configuration)
        {
            //Configure DbContext
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            return services;
        }
    }
}
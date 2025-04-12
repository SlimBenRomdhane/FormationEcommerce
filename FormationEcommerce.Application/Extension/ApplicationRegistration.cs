using FormationEcommerce.Core.Interfaces.Repositories;
using FormationEcommerce.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationEcommerce.Application.Extension
{
    public static class ApplicationRegistration
    {
        public static IServiceCollection AddApplicationServicesRegistration(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            return services;
        }
    }
}

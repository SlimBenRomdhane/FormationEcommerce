using FormationEcommerce.Application.Categories.Interfaces;
using FormationEcommerce.Application.Categories.Mappings;
using FormationEcommerce.Application.Categories.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FormationEcommerce.Application.Extension
{
    public static class ApplicationRegistration
    {
        public static IServiceCollection AddApplicationServicesRegistration(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //alternatively, we can add every profile separatly
            //services.AddAutoMapper(typeof(CategoryProfiles));
            return services;
        }
    }
}
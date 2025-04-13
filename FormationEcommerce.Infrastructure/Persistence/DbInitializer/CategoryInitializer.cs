using FormationEcommerce.Core.Entities.Categories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationEcommerce.Infrastructure.Persistence.DbInitializer
{
    public static class CategoryInitializer
    {
        public static void SeedCategories(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "Electronics",
                    Description = "Devices and gadgets"
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "Books",
                    Description = "Literature and novels"
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "Clothing",
                    Description = "Apparel and accessories"
                }
            );
        }
    }
}

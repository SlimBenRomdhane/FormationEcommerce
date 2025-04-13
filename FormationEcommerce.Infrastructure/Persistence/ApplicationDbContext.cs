using FormationEcommerce.Core.Entities.Carts;
using FormationEcommerce.Core.Entities.Categories;
using FormationEcommerce.Core.Entities.Coupons;
using FormationEcommerce.Core.Entities.Identity;
using FormationEcommerce.Core.Entities.Orders;
using FormationEcommerce.Core.Entities.Products;
using FormationEcommerce.Infrastructure.Persistence.DbInitializer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FormationEcommerce.Infrastructure.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<CartDetail> CartDetails { get; set; }
        public DbSet<CartHeader> CartHeaders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.SeedCategories();
        }
    }
}
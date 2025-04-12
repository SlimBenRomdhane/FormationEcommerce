using FormationEcommerce.Core.Common;
using FormationEcommerce.Core.Entities.Carts;
using FormationEcommerce.Core.Entities.Categories;
using FormationEcommerce.Core.Entities.Orders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FormationEcommerce.Core.Entities.Products
{
    public class Product : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(300, ErrorMessage = "Text length exeed the limit 300 characters")]
        public string Description { get; set; }

        public string ImageUrl { get; set; }

        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }

        public Category Category { get; set; }
        private ICollection<CartDetail> CartDetail { get; set; }
        private ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
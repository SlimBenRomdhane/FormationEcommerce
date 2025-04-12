using FormationEcommerce.Core.Common;
using FormationEcommerce.Core.Entities.Products;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FormationEcommerce.Core.Entities.Orders
{
    public class OrderDetail : BaseEntity
    {
        [Required]
        [ForeignKey("OrderHeader")]
        public Guid OrderHeaderId { get; set; }

        [Required]
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        public int Count { get; set; }
        public OrderHeader OrderHeader { get; set; }
        public Product Product { get; set; }
    }
}
using FormationEcommerce.Core.Common;
using FormationEcommerce.Core.Entities.Products;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FormationEcommerce.Core.Entities.Carts
{
    public class CartDetail : BaseEntity
    {
        [Required]
        [ForeignKey("CartHeader")]
        public Guid CartHeaderId { get; set; }

        [Required]
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "The value must be positive")]
        public int Count { get; set; }

        public CartHeader CartHeader { get; set; }
        public Product Product { get; set; }
    }
}
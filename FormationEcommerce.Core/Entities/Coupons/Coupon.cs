using FormationEcommerce.Core.Common;
using FormationEcommerce.Core.Entities.Carts;
using FormationEcommerce.Core.Entities.Orders;
using System.ComponentModel.DataAnnotations;

namespace FormationEcommerce.Core.Entities.Coupons
{
    public class Coupon : BaseEntity
    {
        [Required]
        public string CouponCode { get; set; }

        [Required]
        [Range(1, Double.MaxValue, ErrorMessage = "The value must be positive")]
        public decimal DiscountAmout { get; set; }

        [Required]
        [Range(1, Double.MaxValue, ErrorMessage = "The value must be positive")]
        public decimal MinAmount { get; set; }

        public string StripeId { get; set; }

        private ICollection<CartHeader>? CartHeaders { get; set; }
        private ICollection<OrderHeader>? OrderHeaders { get; set; }
    }
}
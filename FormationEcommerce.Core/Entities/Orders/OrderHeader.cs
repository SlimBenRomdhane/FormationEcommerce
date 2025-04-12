using FormationEcommerce.Core.Common;
using FormationEcommerce.Core.Entities.Coupons;
using FormationEcommerce.Core.Entities.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FormationEcommerce.Core.Entities.Orders
{
    public class OrderHeader : BaseEntity
    {
        [Required]
        [ForeignKey("User")]
        public string UserId { get; set; }

        public string? CouponCode { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Discount { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal OrderTotal { get; set; }

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        [Required]
        public DateTime OrderTime { get; set; } = DateTime.UtcNow;

        public string Status { get; set; }
        public string? PaymentIntentId { get; set; }
        public string? StripeSessionId { get; set; }

        [ForeignKey("Coupon")]
        public Guid CouponId { get; set; }

        public Coupon Coupon { get; set; }
        public ApplicationUser User { get; set; }

        private ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
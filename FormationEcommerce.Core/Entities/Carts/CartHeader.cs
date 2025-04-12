using FormationEcommerce.Core.Common;
using FormationEcommerce.Core.Entities.Coupons;
using FormationEcommerce.Core.Entities.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FormationEcommerce.Core.Entities.Carts
{
    public class CartHeader : BaseEntity
    {
        [Required]
        [ForeignKey("User")]
        public string UserId { get; set; }

        [Required]
        [ForeignKey("Coupon")]
        public Guid CouponId { get; set; }

        [Required]
        public string CouponCode { get; set; }

        public ApplicationUser User { get; set; }
        public Coupon Coupon { get; set; }
        private ICollection<CartDetail> CartDetails { get; set; }
    }
}
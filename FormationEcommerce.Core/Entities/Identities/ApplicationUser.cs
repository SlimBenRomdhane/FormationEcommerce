using FormationEcommerce.Core.Entities.Carts;
using FormationEcommerce.Core.Entities.Orders;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FormationEcommerce.Core.Entities.Identity
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Range(1000, 9999, ErrorMessage = "Code out of range, it must be between 1000 and 9999")]
        public int ZipCode { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Address cannot exeed 255 characters")]
        public string Address { get; set; }

        public ICollection<CartHeader> CartHeaders { get; set; }
        public ICollection<OrderHeader> OrderHeaders { get; set; }
    }
}
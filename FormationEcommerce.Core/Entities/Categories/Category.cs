using FormationEcommerce.Core.Common;
using FormationEcommerce.Core.Entities.Products;
using System.ComponentModel.DataAnnotations;

namespace FormationEcommerce.Core.Entities.Categories
{
    public class Category : BaseEntity
    {
        [Required(ErrorMessage = "Would you please provide a Category Name")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Would you please provide a Category Description")]
        [MaxLength(500)]
        public string Description { get; set; }

        private ICollection<Product>? Products { get; set; }
    }
}
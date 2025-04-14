using System.ComponentModel.DataAnnotations;

namespace FormationEcommerce.Web.Models.Categories
{
    public class CreateCategoryViewModel
    {
        [Required]
        public required string Name { get; set; }
        [MaxLength(100)]
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    }
}

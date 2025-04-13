using System.ComponentModel.DataAnnotations;

namespace FormationEcommerce.Application.Categories.Dtos
{
    public class CreateCategoryDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
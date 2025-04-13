using System.ComponentModel.DataAnnotations;

namespace FormationEcommerce.Application.Categories.Dtos
{
    public class UpdateCategoryDto
    {
        public Guid Id { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }

        public DateTime LastModificationDate { get; set; } = DateTime.Now;
    }
}
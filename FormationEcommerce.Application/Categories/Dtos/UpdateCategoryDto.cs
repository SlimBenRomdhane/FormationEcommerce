using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

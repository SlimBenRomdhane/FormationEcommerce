using AutoMapper;
using FormationEcommerce.Application.Categories.Dtos;
using FormationEcommerce.Core.Entities.Categories;

namespace FormationEcommerce.Application.Categories.Mappings
{
    public class CategoryProfiles : Profile
    {
        public CategoryProfiles()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<CreateCategoryDto, Category>();
            CreateMap<UpdateCategoryDto, Category>();
        }
    }
}
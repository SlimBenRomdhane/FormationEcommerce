using AutoMapper;
using FormationEcommerce.Application.Categories.Dtos;
using FormationEcommerce.Web.Models.Categories;

namespace FormationEcommerce.Web.Mapping
{
    public class CategoryProfiles : Profile
    {
        public CategoryProfiles()
        {
            CreateMap<CategoryDto, CategoryViewModel>().ReverseMap();
            CreateMap<CreateCategoryViewModel, CreateCategoryDto>();
        }
    }

}

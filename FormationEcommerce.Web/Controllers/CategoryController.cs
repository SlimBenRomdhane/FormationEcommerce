using AutoMapper;
using FormationEcommerce.Application.Categories.Interfaces;
using FormationEcommerce.Web.Models.Categories;
using Microsoft.AspNetCore.Mvc;

namespace FormationEcommerce.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var resultDto = await _categoryService.GetAllCategoriesServiceAsync();
                var result = _mapper.Map<IEnumerable<CategoryViewModel>>(resultDto);
                return View(result);
            }
            catch (Exception)
            {
                return View("Error Something went wrong when listing the categories");
                //throw new Exception("Something went wrong when listing the categories");
            }

        }
    }
}

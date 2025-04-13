using FormationEcommerce.Application.Categories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FormationEcommerce.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

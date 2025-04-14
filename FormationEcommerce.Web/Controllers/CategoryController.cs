using AutoMapper;
using FormationEcommerce.Application.Categories.Dtos;
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

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryViewModel createCategoryViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(createCategoryViewModel);
            }
            try
            {
                var createCategoryDto = _mapper.Map<CreateCategoryDto>(createCategoryViewModel);
                var res = await _categoryService.AddCategoryServiceAsync(createCategoryDto);

                if (res != null)
                {
                    return RedirectToAction(nameof(Index));
                }
                return View(createCategoryDto);

            }
            catch (Exception)
            {
                throw new Exception("Something went wrong");
            }
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            await _categoryService.DeleteCategoryServiceAsync(id);
            return RedirectToAction("Index");
        }
    }
}
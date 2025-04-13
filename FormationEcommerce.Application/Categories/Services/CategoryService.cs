using AutoMapper;
using FormationEcommerce.Application.Categories.Dtos;
using FormationEcommerce.Application.Categories.Interfaces;
using FormationEcommerce.Core.Entities.Categories;
using FormationEcommerce.Core.Interfaces.Repositories;

namespace FormationEcommerce.Application.Categories.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CategoryDto> AddCategoryServiceAsync(CreateCategoryDto createCategoryDto)
        {
            try
            {
                var categoryToAdd = _mapper.Map<Category>(createCategoryDto);
                var addedCategory = await _categoryRepository.AddAsyncGeneric(categoryToAdd);
                var categoryDto = _mapper.Map<CategoryDto>(addedCategory);
                var nbr = await _categoryRepository.SaveChangesAsyncGeneric();
                return categoryDto;
            }
            catch (Exception)
            {
                throw new Exception("Something went wrong during the transaction");
            }
        }

        public async Task<CategoryDto> GetCategoryByIdServiceAsync(Guid id)
        {
            var category = await _categoryRepository.GetByIdAsyncGeneric(id);
            if (category == null)
            {
                throw new Exception($"Category with id {id} not found.");
            }
            return _mapper.Map<CategoryDto>(category);
        }

        public async Task<Guid> GetCategoryIdByCategoryNameServiceAsync(string categoryName)
        {
            if (string.IsNullOrEmpty(categoryName))
            {
                throw new ArgumentException("Category name cannot be null or empty.", nameof(categoryName));
            }
            var categoryId = await _categoryRepository.GetCategoryIdByCategoryNameAsync(categoryName);
            return categoryId;
        }

        public async Task<IEnumerable<CategoryDto>> GetAllCategoriesServiceAsync()
        {
            var categories = await _categoryRepository.GetAllAsyncGeneric();
            if (categories == null)
            {
                throw new Exception("No categories found.");
            }
            var categoryDtos = _mapper.Map<IEnumerable<CategoryDto>>(categories);
            return categoryDtos;
        }

        public async Task UpdateCategoryServiceAsync(UpdateCategoryDto updateCategoryDto)
        {
            var categoryToUpdate = await _categoryRepository.GetByIdAsyncGeneric(updateCategoryDto.Id);
            if (categoryToUpdate == null)
            {
                throw new Exception($"Category with id {updateCategoryDto.Id} not found.");
            }
            //This wont work because I just reinserted the same object I fetched from the database
            //await _categoryRepository.UpdateAsyncGeneric(categoryToUpdate);
            await _categoryRepository.UpdateAsyncGeneric(_mapper.Map<Category>(updateCategoryDto));
            await _categoryRepository.SaveChangesAsyncGeneric();
        }

        public async Task DeleteCategoryServiceAsync(Guid id)
        {
            var categoryToDelete = await _categoryRepository.GetByIdAsyncGeneric(id);
            if (categoryToDelete == null)
            {
                throw new Exception($"Category with id {id} not found.");
            }
            await _categoryRepository.DeleteAsyncGeneric(categoryToDelete);
            await _categoryRepository.SaveChangesAsyncGeneric();
        }
    }
}
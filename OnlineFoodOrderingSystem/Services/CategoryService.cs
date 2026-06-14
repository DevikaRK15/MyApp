using OnlineFoodOrderingSystem.DTOs.Category;
using OnlineFoodOrderingSystem.Models;
using OnlineFoodOrderingSystem.Repositories;

namespace OnlineFoodOrderingSystem.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<CategoryResponseDto>> GetAllAsync()
        {
            var categories = await _repository.GetAllAsync();

            return categories.Select(c => new CategoryResponseDto
            {
                CategoryId = c.CategoryId,
                CategoryName = c.CategoryName,
                Description = c.Description
            });
        }

        public async Task<CategoryResponseDto?> GetByIdAsync(int id)
        {
            var category = await _repository.GetByIdAsync(id);

            if (category == null)
                return null;

            return new CategoryResponseDto
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName,
                Description = category.Description
            };
        }

        public async Task<CategoryResponseDto> AddAsync(CategoryCreateDto dto)
        {
            var category = new Category
            {
                CategoryName = dto.CategoryName,
                Description = dto.Description
            };

            await _repository.AddAsync(category);

            return new CategoryResponseDto
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName,
                Description = category.Description
            };
        }

        public async Task<bool> UpdateAsync(int id, CategoryUpdateDto dto)
        {
            var category = await _repository.GetByIdAsync(id);

            if (category == null)
                return false;

            category.CategoryName = dto.CategoryName;
            category.Description = dto.Description;

            await _repository.UpdateAsync(category);

            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var category = await _repository.GetByIdAsync(id);

            if (category == null)
                return false;

            await _repository.DeleteAsync(category);

            return true;
        }
    }
}
using OnlineFoodOrderingSystem.DTOs.Category;

namespace OnlineFoodOrderingSystem.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryResponseDto>> GetAllAsync();

        Task<CategoryResponseDto?> GetByIdAsync(int id);

        Task<CategoryResponseDto> AddAsync(CategoryCreateDto dto);

        Task<bool> UpdateAsync(int id, CategoryUpdateDto dto);

        Task<bool> DeleteAsync(int id);
    }
}
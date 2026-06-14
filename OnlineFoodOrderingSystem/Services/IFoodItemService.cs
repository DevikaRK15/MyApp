using OnlineFoodOrderingSystem.Data;
using OnlineFoodOrderingSystem.DTOs;
using OnlineFoodOrderingSystem.Models;

namespace OnlineFoodOrderingSystem.Services
{
    public interface IFoodItemService
    {
        Task<IEnumerable<FoodItem>> GetAllAsync();

        Task<FoodItem?> GetByIdAsync(int id);

        Task<FoodItem> AddAsync(FoodItemCreateDto dto);

        Task<bool> UpdateAsync(int id, FoodItemUpdateDto dto);

        Task<bool> DeleteAsync(int id);
    }
}
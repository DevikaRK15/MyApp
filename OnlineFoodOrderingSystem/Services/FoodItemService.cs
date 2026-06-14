using OnlineFoodOrderingSystem.Data;
using OnlineFoodOrderingSystem.DTOs;
using OnlineFoodOrderingSystem.Models;
using OnlineFoodOrderingSystem.Repositories;

namespace OnlineFoodOrderingSystem.Services
{
    public class FoodItemService : IFoodItemService
    {
        private readonly IFoodItemRepository _repository;

        public FoodItemService(IFoodItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<FoodItem>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<FoodItem?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<FoodItem> AddAsync(FoodItemCreateDto dto)
        {
            var foodItem = new FoodItem
            {
                FoodName = dto.FoodName,
                Price = dto.Price,
                Description = dto.Description,
                CategoryId = dto.CategoryId
            };

            return await _repository.AddAsync(foodItem);
        }

        public async Task<bool> UpdateAsync(int id, FoodItemUpdateDto dto)
        {
            var foodItem = await _repository.GetByIdAsync(id);

            if (foodItem == null)
                return false;

            foodItem.FoodName = dto.FoodName;
            foodItem.Price = dto.Price;
            foodItem.Description = dto.Description;
            foodItem.CategoryId = dto.CategoryId;

            await _repository.UpdateAsync(foodItem);

            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var foodItem = await _repository.GetByIdAsync(id);

            if (foodItem == null)
                return false;

            await _repository.DeleteAsync(foodItem);

            return true;
        }
    }
}
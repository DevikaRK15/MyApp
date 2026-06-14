using Microsoft.EntityFrameworkCore;
using OnlineFoodOrderingSystem.Data;
using OnlineFoodOrderingSystem.Models;

namespace OnlineFoodOrderingSystem.Repositories
{
    public class FoodItemRepository : IFoodItemRepository
    {
        private readonly FoodOrderingDbContext _context;

        public FoodItemRepository(FoodOrderingDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<FoodItem>> GetAllAsync()
        {
            return await _context.FoodItems
                .Include(f => f.Category)
                .ToListAsync();
        }

        public async Task<FoodItem?> GetByIdAsync(int id)
        {
            return await _context.FoodItems
                .Include(f => f.Category)
                .FirstOrDefaultAsync(f => f.FoodItemId == id);
        }

        public async Task<FoodItem> AddAsync(FoodItem foodItem)
        {
            await _context.FoodItems.AddAsync(foodItem);
            await _context.SaveChangesAsync();

            return foodItem;
        }

        public async Task UpdateAsync(FoodItem foodItem)
        {
            _context.FoodItems.Update(foodItem);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(FoodItem foodItem)
        {
            _context.FoodItems.Remove(foodItem);
            await _context.SaveChangesAsync();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using OnlineFoodOrderingSystem.DTOs;
using OnlineFoodOrderingSystem.Services;

namespace OnlineFoodOrderingSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FoodItemsController : ControllerBase
    {
        private readonly IFoodItemService _service;

        public FoodItemsController(IFoodItemService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var items = await _service.GetAllAsync();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await _service.GetByIdAsync(id);

            if (item == null)
                return NotFound();

            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create(FoodItemCreateDto dto)
        {
            var item = await _service.AddAsync(dto);

            return CreatedAtAction(
                nameof(GetById),
                new { id = item.FoodItemId },
                item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, FoodItemUpdateDto dto)
        {
            var result = await _service.UpdateAsync(id, dto);

            if (!result)
                return NotFound();

            return Ok("Food Item Updated Successfully");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _service.DeleteAsync(id);

            if (!result)
                return NotFound();

            return Ok("Food Item Deleted Successfully");
        }
    }
}
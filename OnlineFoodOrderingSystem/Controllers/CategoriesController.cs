using Microsoft.AspNetCore.Mvc;
using OnlineFoodOrderingSystem.DTOs.Category;
using OnlineFoodOrderingSystem.Services;

namespace OnlineFoodOrderingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _service;

        public CategoriesController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _service.GetAllAsync();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _service.GetByIdAsync(id);

            if (category == null)
                return NotFound();

            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryCreateDto dto)
        {
            var category = await _service.AddAsync(dto);

            return CreatedAtAction(
                nameof(GetById),
                new { id = category.CategoryId },
                category);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(
            int id,
            CategoryUpdateDto dto)
        {
            var result = await _service.UpdateAsync(id, dto);

            if (!result)
                return NotFound();

            return Ok("Category Updated Successfully");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _service.DeleteAsync(id);

            if (!result)
                return NotFound();

            return Ok("Category Deleted Successfully");
        }
    }
}
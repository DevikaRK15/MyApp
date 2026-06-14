using Microsoft.AspNetCore.Mvc;
using OnlineFoodOrderingSystem.DTOs;
using OnlineFoodOrderingSystem.Services;

namespace OnlineFoodOrderingSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderDetailsController : ControllerBase
    {
        private readonly IOrderDetailService _service;

        public OrderDetailsController(IOrderDetailService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAllAsync());
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
        public async Task<IActionResult> Create(OrderDetailCreateDto dto)
        {
            var item = await _service.AddAsync(dto);

            return CreatedAtAction(
                nameof(GetById),
                new { id = item.OrderDetailId },
                item);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _service.DeleteAsync(id);

            if (!result)
                return NotFound();

            return Ok("Order Detail Deleted Successfully");
        }
    }
}
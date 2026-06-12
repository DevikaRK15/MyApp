using LeaveManagementAPI.DTOs;
using LeaveManagementAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeavesController : ControllerBase
    {
        private readonly ILeaveService _service;

        public LeavesController(ILeaveService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> ApplyLeave(LeaveRequestDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (dto.EndDate < dto.StartDate)
                return BadRequest("End Date cannot be less than Start Date");

            await _service.ApplyLeaveAsync(dto);

            return Ok("Leave Applied Successfully");
        }

        [HttpPut("approve/{id}")]
        public async Task<IActionResult> Approve(int id)
        {
            await _service.ApproveLeaveAsync(id);
            return Ok("Leave Approved");
        }

        [HttpPut("reject/{id}")]
        public async Task<IActionResult> Reject(int id)
        {
            await _service.RejectLeaveAsync(id);
            return Ok("Leave Rejected");
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLeaves()
        {
            var leaves = await _service.GetAllLeavesAsync();
            return Ok(leaves);
        }

        [HttpGet("pending")]
        public async Task<IActionResult> GetPendingLeaves()
        {
            var leaves = await _service.GetPendingLeavesAsync();
            return Ok(leaves);
        }
    }
}
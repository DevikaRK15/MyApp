using LeaveManagementAPI.DTOs;
using LeaveManagementAPI.Models;
using LeaveManagementAPI.Repositories;

namespace LeaveManagementAPI.Services
{
    public class LeaveService : ILeaveService
    {
        private readonly ILeaveRepository _repository;

        public LeaveService(ILeaveRepository repository)
        {
            _repository = repository;
        }

        public async Task ApplyLeaveAsync(LeaveRequestDTO dto)
        {
            var leave = new LeaveRequest
            {
                EmployeeId = dto.EmployeeId,
                LeaveTypeId = dto.LeaveTypeId,
                StartDate = dto.StartDate,
                EndDate = dto.EndDate,
                Reason = dto.Reason
            };

            await _repository.AddAsync(leave);
        }

        public async Task ApproveLeaveAsync(int id)
        {
            var leave = await _repository.GetByIdAsync(id);

            leave.Status = "Approved";

            await _repository.UpdateAsync(leave);
        }

        public async Task RejectLeaveAsync(int id)
        {
            var leave = await _repository.GetByIdAsync(id);

            leave.Status = "Rejected";

            await _repository.UpdateAsync(leave);
        }
        

        public async Task<IEnumerable<LeaveRequest>> GetAllLeavesAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<IEnumerable<LeaveRequest>> GetPendingLeavesAsync()
        {
            return await _repository.GetPendingAsync();
        }

    }
}
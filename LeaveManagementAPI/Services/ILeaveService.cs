using LeaveManagementAPI.DTOs;
using LeaveManagementAPI.Models;

namespace LeaveManagementAPI.Services
{
    public interface ILeaveService
    {
        Task ApplyLeaveAsync(LeaveRequestDTO dto);
        Task ApproveLeaveAsync(int id);
        Task RejectLeaveAsync(int id);

        Task<IEnumerable<LeaveRequest>> GetAllLeavesAsync();
        Task<IEnumerable<LeaveRequest>> GetPendingLeavesAsync();
    }
}
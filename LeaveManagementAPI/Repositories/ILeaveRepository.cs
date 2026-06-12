using LeaveManagementAPI.Models;

namespace LeaveManagementAPI.Repositories
{
    public interface ILeaveRepository
    {
        Task<IEnumerable<LeaveRequest>> GetAllAsync();
        Task<LeaveRequest> GetByIdAsync(int id);
        Task AddAsync(LeaveRequest request);
        Task UpdateAsync(LeaveRequest request);

        Task<IEnumerable<LeaveRequest>> GetPendingAsync();
    }
}
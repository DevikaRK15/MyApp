using System.ComponentModel.DataAnnotations;

namespace LeaveManagementAPI.Models
{
    public class LeaveRequest
    {
        public int LeaveRequestId { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int LeaveTypeId { get; set; }
        public LeaveType LeaveType { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public string Reason { get; set; }

        public string Status { get; set; } = "Pending";

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
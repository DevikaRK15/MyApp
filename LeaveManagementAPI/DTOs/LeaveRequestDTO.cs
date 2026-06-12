using System.ComponentModel.DataAnnotations;

namespace LeaveManagementAPI.DTOs
{
    public class LeaveRequestDTO
    {
        public int EmployeeId { get; set; }

        public int LeaveTypeId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public string Reason { get; set; }
    }
}
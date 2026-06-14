using System.ComponentModel.DataAnnotations;

namespace OnlineFoodOrderingSystem.Models
{
    public class AuditLog
    {

        [Key]
        public int AuditId { get; set; }

        public string ActionName { get; set; }

        public DateTime ActionDate { get; set; }
    }
}
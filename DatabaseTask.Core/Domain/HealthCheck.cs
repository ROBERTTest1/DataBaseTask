using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class HealthCheck
    {
        [Key]
        [Column("health_id")]
        public int HealthId { get; set; } // PK

        // FK Employee
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public DateTime CheckDate { get; set; }
        public string Comments { get; set; }
        public bool IsChecked { get; set; }
    }
}
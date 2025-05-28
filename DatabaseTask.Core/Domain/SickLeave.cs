using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class SickLeave
    {
        [Column("sickLeave_id")]
        public int SickLeaveId { get; set; } // PK

        // FK Employee
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public string Replacement { get; set; }
    }
}
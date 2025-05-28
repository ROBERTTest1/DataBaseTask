using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Kid
    {
        [Key]
        [Column("kids_id")]
        public int KidsId { get; set; } // PK

        // FK Employee
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public string FirstName { get; set; }
        public DateTime Birthday { get; set; }
    }
}
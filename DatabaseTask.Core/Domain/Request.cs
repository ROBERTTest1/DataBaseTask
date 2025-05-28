using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Request
    {
        [Key]
        [Column("request_id")]
        public int RequestId { get; set; } // PK

        public string RequestType { get; set; }
        public DateTime RequestDate { get; set; }

        // FK Employee
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public string Comment { get; set; }

        // FK Company
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
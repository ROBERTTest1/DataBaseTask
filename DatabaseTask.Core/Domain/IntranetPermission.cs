using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class IntranetPermission
    {
        [Column("permission_id")]
        public int PermissionId { get; set; } // PK

        // FK Employee
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public string PermissionName { get; set; }
        public string Comments { get; set; }
        public DateTime PermissionGrantedDate { get; set; }
        public DateTime PermissionEndDate { get; set; }

        // FK Company
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
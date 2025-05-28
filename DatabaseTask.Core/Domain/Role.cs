using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Role
    {
        [Column("role_id")]
        public int RoleId { get; set; } // PK

        public string RoleName { get; set; }

        // FK Branch
        public int BranchId { get; set; }
        public Branch Branch { get; set; }

        // FK Employee
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
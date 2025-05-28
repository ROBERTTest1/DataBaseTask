using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Branch
    {
        [Key]
        [Column("branch_id")]
        public int BranchId { get; set; } // PK

        public string BranchName { get; set; }
        public string Address { get; set; }

        // FK Company
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
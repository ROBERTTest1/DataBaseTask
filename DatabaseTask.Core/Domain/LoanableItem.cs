using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class LoanableItem
    {
        [Column("loanedItem_id")]
        public int LoanedItemId { get; set; } // PK

        public string ItemName { get; set; }
        public DateTime LoanStartingDate { get; set; }
        public DateTime LoanEndingDate { get; set; }
        public bool IsReturned { get; set; }

        // FK Employee
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        // FK Company
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
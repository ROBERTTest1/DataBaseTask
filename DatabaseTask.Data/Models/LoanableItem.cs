using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class LoanableItem
{
    public int LoanedItemId { get; set; }

    public string ItemName { get; set; } = null!;

    public DateTime LoanStartingDate { get; set; }

    public DateTime LoanEndingDate { get; set; }

    public bool IsReturned { get; set; }

    public int EmployeeId { get; set; }

    public int CompanyId { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;
}

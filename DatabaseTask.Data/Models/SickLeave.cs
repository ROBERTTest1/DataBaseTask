using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class SickLeave
{
    public int SickLeaveId { get; set; }

    public int EmployeeId { get; set; }

    public DateTime StartingDate { get; set; }

    public DateTime EndingDate { get; set; }

    public string Replacement { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;
}

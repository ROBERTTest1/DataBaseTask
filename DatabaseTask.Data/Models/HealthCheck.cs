using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class HealthCheck
{
    public int HealthId { get; set; }

    public int EmployeeId { get; set; }

    public DateTime CheckDate { get; set; }

    public string Comments { get; set; } = null!;

    public bool IsChecked { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}

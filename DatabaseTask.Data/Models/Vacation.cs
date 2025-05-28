using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class Vacation
{
    public int VacationId { get; set; }

    public int EmployeeId { get; set; }

    public string Type { get; set; } = null!;

    public int VacationDaysTotal { get; set; }

    public string Comments { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;
}

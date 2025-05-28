using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class Kid
{
    public int KidsId { get; set; }

    public int EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public DateTime Birthday { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}

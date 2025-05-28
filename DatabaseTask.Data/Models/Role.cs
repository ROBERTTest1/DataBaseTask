using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class Role
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public int BranchId { get; set; }

    public int EmployeeId { get; set; }

    public virtual Branch Branch { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;
}

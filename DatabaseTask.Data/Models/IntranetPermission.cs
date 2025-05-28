using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class IntranetPermission
{
    public int PermissionId { get; set; }

    public int EmployeeId { get; set; }

    public string PermissionName { get; set; } = null!;

    public string Comments { get; set; } = null!;

    public DateTime PermissionGrantedDate { get; set; }

    public DateTime PermissionEndDate { get; set; }

    public int CompanyId { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;
}

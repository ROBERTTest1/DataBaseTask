using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class Branch
{
    public int BranchId { get; set; }

    public string BranchName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public int CompanyId { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
}

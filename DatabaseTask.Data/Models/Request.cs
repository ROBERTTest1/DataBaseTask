using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class Request
{
    public int RequestId { get; set; }

    public string RequestType { get; set; } = null!;

    public DateTime RequestDate { get; set; }

    public int EmployeeId { get; set; }

    public string Comment { get; set; } = null!;

    public int CompanyId { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;
}

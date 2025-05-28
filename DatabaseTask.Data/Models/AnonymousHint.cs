using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class AnonymousHint
{
    public int HintId { get; set; }

    public string HintType { get; set; } = null!;

    public DateTime HintDate { get; set; }

    public string Comment { get; set; } = null!;

    public int CompanyId { get; set; }

    public virtual Company Company { get; set; } = null!;
}

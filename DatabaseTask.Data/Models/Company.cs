using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class Company
{
    public int CompanyId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string RegisterCode { get; set; } = null!;

    public string Address { get; set; } = null!;

    public virtual ICollection<AnonymousHint> AnonymousHints { get; set; } = new List<AnonymousHint>();

    public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();

    public virtual ICollection<IntranetPermission> IntranetPermissions { get; set; } = new List<IntranetPermission>();

    public virtual ICollection<LoanableItem> LoanableItems { get; set; } = new List<LoanableItem>();

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
}

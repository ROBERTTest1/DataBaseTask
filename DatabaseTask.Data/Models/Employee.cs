using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public DateTime Birthday { get; set; }

    public string Comments { get; set; } = null!;

    public string PersonalCode { get; set; } = null!;

    public DateTime StartingDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual ICollection<HealthCheck> HealthChecks { get; set; } = new List<HealthCheck>();

    public virtual ICollection<IntranetPermission> IntranetPermissions { get; set; } = new List<IntranetPermission>();

    public virtual ICollection<Kid> Kids { get; set; } = new List<Kid>();

    public virtual ICollection<LoanableItem> LoanableItems { get; set; } = new List<LoanableItem>();

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();

    public virtual ICollection<SickLeave> SickLeaves { get; set; } = new List<SickLeave>();

    public virtual ICollection<Vacation> Vacations { get; set; } = new List<Vacation>();
}

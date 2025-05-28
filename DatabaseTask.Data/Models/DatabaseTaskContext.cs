using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Data.Models;

public partial class DatabaseTaskContext : DbContext
{
    public DatabaseTaskContext()
    {
    }

    public DatabaseTaskContext(DbContextOptions<DatabaseTaskContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AnonymousHint> AnonymousHints { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<HealthCheck> HealthChecks { get; set; }

    public virtual DbSet<IntranetPermission> IntranetPermissions { get; set; }

    public virtual DbSet<Kid> Kids { get; set; }

    public virtual DbSet<LoanableItem> LoanableItems { get; set; }

    public virtual DbSet<Request> Requests { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<SickLeave> SickLeaves { get; set; }

    public virtual DbSet<Vacation> Vacations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost,1433;Database=DatabaseTask;User Id=sa;Password=Prodatorhd123;TrustServerCertificate=True;MultipleActiveResultSets=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AnonymousHint>(entity =>
        {
            entity.HasKey(e => e.HintId);

            entity.ToTable("AnonymousHint");

            entity.HasIndex(e => e.CompanyId, "IX_AnonymousHint_CompanyId");

            entity.HasOne(d => d.Company).WithMany(p => p.AnonymousHints).HasForeignKey(d => d.CompanyId);
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.ToTable("Branch");

            entity.HasIndex(e => e.CompanyId, "IX_Branch_CompanyId");

            entity.Property(e => e.BranchId).HasColumnName("branch_id");

            entity.HasOne(d => d.Company).WithMany(p => p.Branches).HasForeignKey(d => d.CompanyId);
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.ToTable("Company");

            entity.Property(e => e.CompanyId).HasColumnName("company_id");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.ToTable("Employee");

            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
        });

        modelBuilder.Entity<HealthCheck>(entity =>
        {
            entity.HasKey(e => e.HealthId);

            entity.ToTable("HealthCheck");

            entity.HasIndex(e => e.EmployeeId, "IX_HealthCheck_EmployeeId");

            entity.Property(e => e.HealthId).HasColumnName("health_id");

            entity.HasOne(d => d.Employee).WithMany(p => p.HealthChecks).HasForeignKey(d => d.EmployeeId);
        });

        modelBuilder.Entity<IntranetPermission>(entity =>
        {
            entity.HasKey(e => e.PermissionId);

            entity.ToTable("IntranetPermission");

            entity.HasIndex(e => e.CompanyId, "IX_IntranetPermission_CompanyId");

            entity.HasIndex(e => e.EmployeeId, "IX_IntranetPermission_EmployeeId");

            entity.Property(e => e.PermissionId).HasColumnName("permission_id");

            entity.HasOne(d => d.Company).WithMany(p => p.IntranetPermissions).HasForeignKey(d => d.CompanyId);

            entity.HasOne(d => d.Employee).WithMany(p => p.IntranetPermissions).HasForeignKey(d => d.EmployeeId);
        });

        modelBuilder.Entity<Kid>(entity =>
        {
            entity.HasKey(e => e.KidsId);

            entity.ToTable("Kid");

            entity.HasIndex(e => e.EmployeeId, "IX_Kid_EmployeeId");

            entity.Property(e => e.KidsId).HasColumnName("kids_id");

            entity.HasOne(d => d.Employee).WithMany(p => p.Kids).HasForeignKey(d => d.EmployeeId);
        });

        modelBuilder.Entity<LoanableItem>(entity =>
        {
            entity.HasKey(e => e.LoanedItemId);

            entity.ToTable("LoanableItem");

            entity.HasIndex(e => e.CompanyId, "IX_LoanableItem_CompanyId");

            entity.HasIndex(e => e.EmployeeId, "IX_LoanableItem_EmployeeId");

            entity.Property(e => e.LoanedItemId).HasColumnName("loanedItem_id");

            entity.HasOne(d => d.Company).WithMany(p => p.LoanableItems).HasForeignKey(d => d.CompanyId);

            entity.HasOne(d => d.Employee).WithMany(p => p.LoanableItems).HasForeignKey(d => d.EmployeeId);
        });

        modelBuilder.Entity<Request>(entity =>
        {
            entity.ToTable("Request");

            entity.HasIndex(e => e.CompanyId, "IX_Request_CompanyId");

            entity.HasIndex(e => e.EmployeeId, "IX_Request_EmployeeId");

            entity.Property(e => e.RequestId).HasColumnName("request_id");

            entity.HasOne(d => d.Company).WithMany(p => p.Requests).HasForeignKey(d => d.CompanyId);

            entity.HasOne(d => d.Employee).WithMany(p => p.Requests).HasForeignKey(d => d.EmployeeId);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("Role");

            entity.HasIndex(e => e.BranchId, "IX_Role_BranchId");

            entity.HasIndex(e => e.EmployeeId, "IX_Role_EmployeeId");

            entity.Property(e => e.RoleId).HasColumnName("role_id");

            entity.HasOne(d => d.Branch).WithMany(p => p.Roles).HasForeignKey(d => d.BranchId);

            entity.HasOne(d => d.Employee).WithMany(p => p.Roles).HasForeignKey(d => d.EmployeeId);
        });

        modelBuilder.Entity<SickLeave>(entity =>
        {
            entity.ToTable("SickLeave");

            entity.HasIndex(e => e.EmployeeId, "IX_SickLeave_EmployeeId");

            entity.Property(e => e.SickLeaveId).HasColumnName("sickLeave_id");

            entity.HasOne(d => d.Employee).WithMany(p => p.SickLeaves).HasForeignKey(d => d.EmployeeId);
        });

        modelBuilder.Entity<Vacation>(entity =>
        {
            entity.ToTable("Vacation");

            entity.HasIndex(e => e.EmployeeId, "IX_Vacation_EmployeeId");

            entity.Property(e => e.VacationId).HasColumnName("vacation_id");

            entity.HasOne(d => d.Employee).WithMany(p => p.Vacations).HasForeignKey(d => d.EmployeeId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

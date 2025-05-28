using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<AnonymousHint> AnonymousHint { get; set; }
        public DbSet<Request> Request { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<LoanableItem> LoanableItem { get; set; }
        public DbSet<IntranetPermission> IntranetPermission { get; set; }
        public DbSet<Kid> Kid { get; set; }
        public DbSet<Vacation> Vacation { get; set; }
        public DbSet<HealthCheck> HealthCheck { get; set; }
        public DbSet<SickLeave> SickLeave { get; set; }
    }
}

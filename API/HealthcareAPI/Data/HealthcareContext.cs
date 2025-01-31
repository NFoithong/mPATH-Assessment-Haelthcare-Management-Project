public class HealthcareContext : DbContext
{
    public HealthcareContext(DbContextOptions<HealthcareContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Recommendation> Recommendations { get; set; }
    public DbSet<AuditLog> AuditLogs { get; set; }
    public DbSet<Role> Roles { get; set; }
}


//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;
//using HealthcareAPI.Models;

//namespace HealthcareAPI.Data
//{
//    public class AppDbContext : IdentityDbContext<IdentityUser>
//    {
//        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

//        public DbSet<Patient> Patients { get; set; }
//        public DbSet<Recommendation> Recommendations { get; set; }
//    }

//}

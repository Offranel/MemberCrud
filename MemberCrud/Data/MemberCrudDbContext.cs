using Microsoft.EntityFrameworkCore;
using MemberCrud.Models;

namespace MemberCrud.Data
{
    public class MemberCrudDbContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Ministry> Ministries { get; set; }
        public DbSet<MemberMinistry> MemberMinistries { get; set; }
        public DbSet<VolunteerMessage> VolunteerMessages { get; set; }

        // Parameterless constructor used by the application when no external
        // DbContextOptions are provided. The OnConfiguring method will
        // configure SQL Server in that case.
        public MemberCrudDbContext()
        {
        }

        // Constructor that accepts DbContextOptions so unit tests can provide
        // an in-memory provider or other configuration.
        public MemberCrudDbContext(DbContextOptions<MemberCrudDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Only configure the SQL Server provider when no options were
            // supplied (for example, in the running WinForms app). Tests can
            // supply their own provider via the options constructor.
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=(localdb)\\MSSQLLocalDB;Database=MemberCrud;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}
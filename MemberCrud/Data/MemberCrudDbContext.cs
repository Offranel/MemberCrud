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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=MemberCrud;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
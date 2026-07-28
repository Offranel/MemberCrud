using Microsoft.EntityFrameworkCore;
using MemberCrud.Models;

namespace MemberCrud.Data
{
    public class ChurchContext : DbContext
    {
        public ChurchContext(DbContextOptions<ChurchContext> options) : base(options)
        {
        }

        public DbSet<Member> Members { get; set; }

        public DbSet<Ministry> Ministries { get; set; }

        public DbSet<MemberMinistry> MemberMinistries { get; set; }
    }
}

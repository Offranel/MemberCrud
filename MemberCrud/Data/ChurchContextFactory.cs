using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MemberCrud.Data
{
    // Design-time factory for EF tools (migrations)
    public class ChurchContextFactory : IDesignTimeDbContextFactory<ChurchContext>
    {
        public ChurchContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ChurchContext>();
            var connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=ChurchDB;Trusted_Connection=True;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(connectionString);
            return new ChurchContext(optionsBuilder.Options);
        }
    }
}

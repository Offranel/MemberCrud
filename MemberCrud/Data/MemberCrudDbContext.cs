using Microsoft.EntityFrameworkCore;
using MemberCrud.Models;

namespace MemberCrud.Data
{
    /// <summary>
    /// Represents the Entity Framework Core database context
    /// for the Church Member Manager application.
    ///
    /// This class provides the connection between the C# application
    /// and the MemberCrud SQL Server database.
    ///
    /// Each DbSet represents a table in the database and allows
    /// Entity Framework Core to read, add, update, and delete data.
    /// </summary>
    public class MemberCrudDbContext : DbContext
    {
        /// <summary>
        /// Represents the Members table in the database.
        /// Stores information about church members.
        /// </summary>
        public DbSet<Member> Members { get; set; }

        /// <summary>
        /// Represents the Ministries table in the database.
        /// Stores information about church ministries.
        /// </summary>
        public DbSet<Ministry> Ministries { get; set; }

        /// <summary>
        /// Represents the MemberMinistries table in the database.
        /// Stores the relationships between members and ministries.
        /// </summary>
        public DbSet<MemberMinistry> MemberMinistries { get; set; }

        /// <summary>
        /// Represents the VolunteerMessages table in the database.
        /// Stores volunteer messages associated with church members.
        /// </summary>
        public DbSet<VolunteerMessage> VolunteerMessages { get; set; }

        /// <summary>
        /// Configures Entity Framework Core to connect to the
        /// MemberCrud SQL Server LocalDB database.
        /// </summary>
        /// <param name="optionsBuilder">
        /// The options builder used to configure the database connection.
        /// </param>
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            // Tells Entity Framework Core to use SQL Server
            // as the database provider.
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=MemberCrud;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
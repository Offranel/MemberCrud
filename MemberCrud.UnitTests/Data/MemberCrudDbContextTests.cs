using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MemberCrud.UnitTests.Data
{
    [TestClass]
    public class MemberCrudDbContextTests
    {
        [Ignore("Crashes test host: Missing SqlServer provider assembly when calling UseSqlServer")]
        [TestMethod]
        public void OnConfiguring_UnconfiguredBuilder_BecomesConfigured()
        {
            // Arrange
            var optionsBuilder = new DbContextOptionsBuilder();
            Assert.IsFalse(optionsBuilder.IsConfigured, "Precondition: builder should start unconfigured");
            var ctx = new TestableMemberCrudDbContext();

            // Act
            ctx.CallOnConfiguring(optionsBuilder);

            // Assert
            Assert.IsTrue(optionsBuilder.IsConfigured, "OnConfiguring should configure the options builder");
            var hasSqlServer = optionsBuilder.Options.Extensions.Any(e =>
                e.GetType().Name.IndexOf("SqlServer", StringComparison.OrdinalIgnoreCase) >= 0);
            Assert.IsTrue(hasSqlServer, "UseSqlServer should have been applied to the options builder");
        }

        [Ignore("Crashes test host: Missing SqlServer provider assembly when calling UseSqlServer")]
        [TestMethod]
        public void OnConfiguring_CalledTwice_RemainsConfigured()
        {
            // Arrange
            var optionsBuilder = new DbContextOptionsBuilder();
            var ctx = new TestableMemberCrudDbContext();

            // Act
            ctx.CallOnConfiguring(optionsBuilder);
            ctx.CallOnConfiguring(optionsBuilder);

            // Assert
            Assert.IsTrue(optionsBuilder.IsConfigured, "Options builder should remain configured after repeated calls");
            var sqlServerExtensions = optionsBuilder.Options.Extensions
                .Where(e => e.GetType().Name.IndexOf("SqlServer", StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            Assert.AreNotEqual(0, sqlServerExtensions.Count, "There should be at least one SqlServer extension present");
        }

        // Helper derived class to expose the protected OnConfiguring method for testing
        private class TestableMemberCrudDbContext : MemberCrud.Data.MemberCrudDbContext
        {
            public void CallOnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                // Call the protected method from the base class
                base.OnConfiguring(optionsBuilder);
            }
        }
    }
}

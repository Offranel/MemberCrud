using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MemberCrud.Data;
using MemberCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace MemberCrud.UnitTests.Data
{
    [TestClass]
    public class MemberCrudDbContextTests
    {
        [TestMethod]
        public void OnConfiguring_DefaultConstructor_SetsSqlServerProviderAndConnectionString()
        {
            // Arrange & Act
            using var context = new MemberCrudDbContext();

            // Assert
            // ProviderName should indicate SQL Server was configured
            string? provider = context.Database.ProviderName;
            Assert.IsFalse(string.IsNullOrEmpty(provider), "ProviderName should not be null or empty");
            StringAssert.Contains(provider, "SqlServer");

            // The configured connection string should include the expected database name and trusted connection flag
            DbConnection connection = context.Database.GetDbConnection();
            Assert.IsNotNull(connection);
            Assert.IsTrue(
                connection.ConnectionString.Contains("Database=MemberCrud") ||
                connection.ConnectionString.Contains("Initial Catalog=MemberCrud"),
                $"Connection string '{connection.ConnectionString}' should reference the MemberCrud database");
            Assert.IsTrue(
                connection.ConnectionString.Contains("Trusted_Connection=True") ||
                connection.ConnectionString.Contains("Integrated Security=True"),
                $"Connection string '{connection.ConnectionString}' should indicate a trusted/integrated security connection");
        }

    }
}

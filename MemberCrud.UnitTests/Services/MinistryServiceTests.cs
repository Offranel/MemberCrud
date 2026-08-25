using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using MemberCrud.Services;
using MemberCrud.Models;

namespace MemberCrud.UnitTests
{
    [TestClass]
    public class MinistryServiceTests
    {
        // NOTE: The production MinistryService creates a MemberCrudDbContext
        // internally using the parameterless constructor. That DbContext
        // unconditionally configures SQL Server in OnConfiguring and attempts
        // to connect to LocalDB. Because the service does not accept a
        // DbContext via dependency injection, it is not possible to mock or
        // intercept the database behavior from unit tests without refactoring
        // the production code (to allow injecting a DbContext or factory),
        // or without adding InternalsVisibleTo and test-only hooks. Creating an
        // actual SQL Server LocalDB dependency in unit tests is undesirable.
        //
        // Therefore the following tests are marked as ignored. They document
        // the intended assertions for each method and should be enabled after
        // the service is refactored to allow injecting a testable DbContext.

        [TestMethod]
        [Ignore("Cannot unit test AddMinistry: MemberCrudDbContext is created internally and connects to SQL Server. Refactor to inject DbContext or provide a test hook.")]
        public void AddMinistry_WithValidMinistry_AddsAndSaves()
        {
            // Arrange
            var service = new MinistryService();
            var ministry = new Ministry { Id = 1, Name = "Test", Description = "Desc" };

            // Act
            service.AddMinistry(ministry);

            // Assert
            // Cannot assert without access to the DbContext used internally.
            Assert.Inconclusive("Test is ignored because MemberCrudDbContext cannot be mocked when created internally.");
        }

        [TestMethod]
        [Ignore("Cannot unit test UpdateMinistry: MemberCrudDbContext is created internally and connects to SQL Server. Refactor to inject DbContext or provide a test hook.")]
        public void UpdateMinistry_WithExistingMinistry_UpdatesAndSaves()
        {
            // Arrange
            var service = new MinistryService();
            var ministry = new Ministry { Id = 2, Name = "Existing", Description = "Desc" };

            // Act
            service.UpdateMinistry(ministry);

            // Assert
            Assert.Inconclusive("Test is ignored because MemberCrudDbContext cannot be mocked when created internally.");
        }

        [TestMethod]
        [Ignore("Cannot unit test DeleteMinistry: MemberCrudDbContext is created internally and connects to SQL Server. Refactor to inject DbContext or provide a test hook.")]
        public void DeleteMinistry_WhenMinistryExists_RemovesAndSaves()
        {
            // Arrange
            var service = new MinistryService();
            int id = 3;

            // Act
            service.DeleteMinistry(id);

            // Assert
            Assert.Inconclusive("Test is ignored because MemberCrudDbContext cannot be mocked when created internally.");
        }

        [TestMethod]
        [Ignore("Cannot unit test GetAllMinistries: MemberCrudDbContext is created internally and connects to SQL Server. Refactor to inject DbContext or provide a test hook.")]
        public void GetAllMinistries_ReturnsListOfMinistries()
        {
            // Arrange
            var service = new MinistryService();

            // Act
            var result = service.GetAllMinistries();

            // Assert
            Assert.Inconclusive("Test is ignored because MemberCrudDbContext cannot be mocked when created internally.");
        }

        [TestMethod]
        [Ignore("Cannot unit test GetMinistryById: MemberCrudDbContext is created internally and connects to SQL Server. Refactor to inject DbContext or provide a test hook.")]
        public void GetMinistryById_WithExistingId_ReturnsMinistry()
        {
            // Arrange
            var service = new MinistryService();
            int id = 4;

            // Act
            var result = service.GetMinistryById(id);

            // Assert
            Assert.Inconclusive("Test is ignored because MemberCrudDbContext cannot be mocked when created internally.");
        }

        [TestMethod]
        [Ignore("Cannot unit test GetMembersForMinistry: MemberCrudDbContext is created internally and connects to SQL Server. Refactor to inject DbContext or provide a test hook.")]
        public void GetMembersForMinistry_WithExistingMinistry_ReturnsMembers()
        {
            // Arrange
            var service = new MinistryService();
            int ministryId = 1;

            // Act
            var result = service.GetMembersForMinistry(ministryId);

            // Assert
            Assert.Inconclusive("Test is ignored because MemberCrudDbContext cannot be mocked when created internally.");
        }

        [TestMethod]
        [Ignore("Cannot unit test AssignMemberToMinistry: MemberCrudDbContext is created internally and connects to SQL Server. Refactor to inject DbContext or provide a test hook.")]
        public void AssignMemberToMinistry_NewAssignment_AddsAndSaves()
        {
            // Arrange
            var service = new MinistryService();
            int ministryId = 1;
            int memberId = 2;

            // Act
            service.AssignMemberToMinistry(ministryId, memberId);

            // Assert
            Assert.Inconclusive("Test is ignored because MemberCrudDbContext cannot be mocked when created internally.");
        }

        [TestMethod]
        [Ignore("Cannot unit test RemoveMemberFromMinistry: MemberCrudDbContext is created internally and connects to SQL Server. Refactor to inject DbContext or provide a test hook.")]
        public void RemoveMemberFromMinistry_WhenMappingExists_RemovesAndSaves()
        {
            // Arrange
            var service = new MinistryService();
            int ministryId = 1;
            int memberId = 2;

            // Act
            service.RemoveMemberFromMinistry(ministryId, memberId);

            // Assert
            Assert.Inconclusive("Test is ignored because MemberCrudDbContext cannot be mocked when created internally.");
        }
    }
}

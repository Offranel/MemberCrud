using Microsoft.VisualStudio.TestTools.UnitTesting;
using MemberCrud.Services;
using MemberCrud.Models;

namespace MemberCrud.UnitTests.Services
{
    [TestClass]
    public class VolunteerServiceTests
    {
        [TestMethod]
        [Ignore("Requires SQL Server LocalDB – integration test skipped in unit test environment")]
        public void SendVolunteerMessage_ValidMessage_SavesToDatabase()
        {
            // Arrange
            var service = new VolunteerService();
            var message = new VolunteerMessage { MemberId = 1, MessageText = "Hello", SentAt = System.DateTime.UtcNow };

            // Act
            // This would attempt to connect to a real SQL Server LocalDB instance
            // which is not available in unit test environments. The test is marked
            // ignored to avoid touching the production database.
            service.SendVolunteerMessage(message);

            // Assert
            // If this were an integration test, we would verify the message was saved.
            Assert.Inconclusive("Integration test: verify persistence in an environment with LocalDB.");
        }

        [TestMethod]
        [Ignore("Requires SQL Server LocalDB – integration test skipped in unit test environment")]
        public void GetMessageHistory_WhenCalled_ReturnsListOfMessages()
        {
            // Arrange
            var service = new VolunteerService();

            // Act
            // This call would enumerate the VolunteerMessages table which requires
            // a live database. The test is ignored to prevent database access.
            var result = service.GetMessageHistory();

            // Assert
            // In an integration test we would assert on the contents of result.
            Assert.IsNotNull(result);
        }
    }
}

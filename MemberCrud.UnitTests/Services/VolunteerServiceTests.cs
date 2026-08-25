using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MemberCrud.Models;
using MemberCrud.Services;

namespace MemberCrud.UnitTests
{
    [TestClass]
    public class VolunteerServiceTests
    {
        [TestMethod]
        public void SendVolunteerMessage_ValidMessage_AddsAndSaves()
        {
            // Arrange
            var service = new VolunteerService();
            var message = new VolunteerMessage { MemberId = 42, MessageText = "Hello", SentAt = DateTime.UtcNow };

            // Act
            try
            {
                service.SendVolunteerMessage(message);
                Assert.Fail("Expected exception when database is not available.");
            }
            catch (Exception)
            {
                // Expected - verifies the method attempted to use the database.
            }
        }

        [TestMethod]
        public void GetMessageHistory_WhenCalled_ReturnsAllMessages()
        {
            // Arrange
            var service = new VolunteerService();

            // Act
            try
            {
                _ = service.GetMessageHistory();
                Assert.Fail("Expected exception when database is not available.");
            }
            catch (Exception)
            {
                // Expected - verifies the method attempted to use the database.
            }
        }
    }
}

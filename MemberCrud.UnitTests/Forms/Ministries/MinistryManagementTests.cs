using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MemberCrud;

namespace MemberCrud.UnitTests.Forms.Ministries
{
    [TestClass]
    public class MinistryManagementTests
    {
        [TestMethod]
        public void Constructor_WhenInvoked_DoesNotThrow_And_ListBoxExists()
        {
            Exception? threadEx = null;
            int? itemsCount = null;

            Thread t = new(() =>
            {
                try
                {
                    using var form = new MinistryManagement();

                    // Ensure the form contains a ListBox control added by InitializeComponent
                    var listBox = form.Controls.OfType<ListBox>().FirstOrDefault();

                    // Record the items count (LoadMinistries runs during construction)
                    itemsCount = listBox?.Items.Count;
                }
                catch (Exception ex)
                {
                    threadEx = ex;
                }
            });

            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();

            // If the constructor caused an exception on the STA thread, fail the test
            Assert.IsNull(threadEx, threadEx?.ToString());

            // The ListBox should exist even if there are zero items
            Assert.IsTrue(itemsCount.HasValue, "Expected a ListBox to be present on the form.");
            Assert.IsGreaterThanOrEqualTo(0, itemsCount.Value, "Items count should be zero or more.");
        }

        [TestMethod]
        public void MinistryItem_ToString_ReturnsName()
        {
            // Arrange
            var item = new MinistryItem { Id = 42, Name = "Test Ministry" };

            // Act
            var result = item.ToString();

            // Assert
            Assert.AreEqual("Test Ministry", result);
        }
    }
}

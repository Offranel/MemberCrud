using System.Linq;
using System.Windows.Forms;
using MemberCrud;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MemberCrud.UnitTests
{
    [TestClass]
    public class MinistryManagementTests
    {
        [TestMethod]
        public void Constructor_WhenCalled_InitializesControlsAndFormText()
        {
            // Arrange
            bool created = false;
            Exception? ctorException = null;

            // Act - create the form on an STA thread to satisfy WinForms requirements
            var t = new System.Threading.Thread(() =>
            {
                try
                {
                    using var form = new MinistryManagement();

                    // Verify form title set by InitializeComponent
                    Assert.AreEqual("MinistryManagement", form.Text);

                    // Verify Controls contain expected named controls
                    var ministries = form.Controls.Find("MinistriesLsbx", true);
                    Assert.HasCount(1, (System.Collections.IEnumerable)ministries);

                    var addBtn = form.Controls.Find("AddMinistryBtn", true);
                    Assert.HasCount(1, (System.Collections.IEnumerable)addBtn);

                    var editBtn = form.Controls.Find("EditMinistryBtn", true);
                    Assert.HasCount(1, (System.Collections.IEnumerable)editBtn);

                    var deleteBtn = form.Controls.Find("DeleteMinistryBtn", true);
                    Assert.HasCount(1, (System.Collections.IEnumerable)deleteBtn);

                    created = true;
                }
                catch (Exception ex)
                {
                    ctorException = ex;
                }
            });

            t.SetApartmentState(System.Threading.ApartmentState.STA);
            t.IsBackground = true;
            t.Start();

            // Wait for the thread to finish, but avoid infinite hang if MessageBox is shown
            bool finished = t.Join(5000);

            // Assert
            Assert.IsTrue(finished, "Form creation did not finish in time (possible modal dialog)");
            Assert.IsNull(ctorException, ctorException?.ToString());
            Assert.IsTrue(created, "Constructor did not complete successfully.");
        }

        [TestMethod]
        public void MinistryItem_ToString_ReturnsName()
        {
            // Arrange
            var item = new MinistryItem { Id = 123, Name = "Children" };

            // Act
            var text = item.ToString();

            // Assert
            Assert.AreEqual("Children", text);
        }
    }
}

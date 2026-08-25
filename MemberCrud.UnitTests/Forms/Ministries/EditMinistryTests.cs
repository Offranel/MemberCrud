using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MemberCrud;

namespace MemberCrud.UnitTests.Forms.Ministries
{
    [TestClass]
    public class EditMinistryTests
    {
        [TestMethod]
        public void Constructor_WithId_InitializesControls()
        {
            // Arrange
            const int id = 123;

            // Act
            using var form = new EditMinistry(id);

            // Assert
            // The constructor calls InitializeComponent and wires up controls.
            // We verify key controls exist in the form's control hierarchy by name.
            var ministries = form.Controls.Find("MinistriesLsBx", true).OfType<ListBox>().FirstOrDefault();
            Assert.IsNotNull(ministries, "Ministries list box should be present after construction.");

            var members = form.Controls.Find("MembersLsBx", true).OfType<ListBox>().FirstOrDefault();
            Assert.IsNotNull(members, "Members list box should be present after construction.");

            var addBtn = form.Controls.Find("AddMemberToMinistryBtn", true).OfType<Button>().FirstOrDefault();
            Assert.IsNotNull(addBtn, "AddMemberToMinistryBtn should be present after construction.");

            var removeBtn = form.Controls.Find("RemoveMemberFromMinistryBtn", true).OfType<Button>().FirstOrDefault();
            Assert.IsNotNull(removeBtn, "RemoveMemberFromMinistryBtn should be present after construction.");

            var saveBtn = form.Controls.Find("SaveChangesBtn", true).OfType<Button>().FirstOrDefault();
            Assert.IsNotNull(saveBtn, "SaveChangesBtn should be present after construction.");

            var cancelBtn = form.Controls.Find("CancelChangesBtn", true).OfType<Button>().FirstOrDefault();
            Assert.IsNotNull(cancelBtn, "CancelChangesBtn should be present after construction.");
        }


    }
}

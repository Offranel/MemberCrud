namespace MemberCrud;

/// <summary>
/// Main application window for church administration.
///
/// Provides entry points to manage ministries and members. Event
/// handlers open the corresponding management forms.
/// </summary>
public partial class ChurchManagement : Form
{
    /// <summary>
    /// Initializes the ChurchManagement form and its UI components.
    /// </summary>
    public ChurchManagement()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Opens the MinistryManagement form when the ministries button is clicked.
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event arguments.</param>
    private void MinistryManagemetBtn_Click(object sender, EventArgs e)
    {
        // Instantiate and display the MinistryManagement window.
        MinistryManagement ministryManagement = new MinistryManagement();
        ministryManagement.Show();
    }

    /// <summary>
    /// Opens the MemberManagement form when the members button is clicked.
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event arguments.</param>
    private void MemberManagementBtn_Click(object sender, EventArgs e)
    {
        // Instantiate and display the MemberManagement window.
        MemberManagement memberManagement = new MemberManagement();
        memberManagement.Show();
    }
}

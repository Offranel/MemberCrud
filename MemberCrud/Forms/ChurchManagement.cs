namespace MemberCrud;

public partial class ChurchManagement : Form
{
    public ChurchManagement()
    {
        InitializeComponent();
    }

    private void MinistryManagemetBtn_Click(object sender, EventArgs e)
    {

        // Create an instance of the MinistryManagement form
        MinistryManagement ministryManagement = new MinistryManagement();

        // Show the MinistryManagement form 
        ministryManagement.Show();
    }
}

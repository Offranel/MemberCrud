using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MemberCrud
{
    public partial class MinistryManagement : Form
    {
        public dynamic DatabaseConfig { get; private set; }

        public MinistryManagement()
        {
            InitializeComponent();
            LoadMinistries();
        }

        // Load ministries into the ListBox
        private void LoadMinistries()
        {
            MinistriesLsbx.Items.Clear();

            // Guard against uninitialized runtime-bound config
            if (DatabaseConfig == null)
            {
                MessageBox.Show("Database configuration is not initialized.");
                return;
            }

            string connString;
            try
            {
                // If DatabaseConfig is dynamic, try to get ConnString safely
                connString = DatabaseConfig.ConnString as string ?? Convert.ToString(DatabaseConfig.ConnString);
            }
            catch
            {
                MessageBox.Show("Invalid database configuration.");
                return;
            }

            if (string.IsNullOrWhiteSpace(connString))
            {
                MessageBox.Show("Connection string is missing.");
                return;
            }

            try
            {
                using var conn = new SqlConnection(connString);
                conn.Open();

                using var cmd = new SqlCommand("SELECT Id, Name FROM Ministries", conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MinistriesLsbx.Items.Add(new MinistryItem
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1)
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load ministries: {ex.Message}");
            }
        }

        private void AddMinistryBtn_Click(object sender, EventArgs e)
        {
            var form = new AddMinistry();
            form.ShowDialog();
            LoadMinistries(); // refresh after adding
        }

        private void EditMinistryBtn_Click(object sender, EventArgs e)
        {
            if (MinistriesLsbx.SelectedItem is not MinistryItem selected)
            {
                MessageBox.Show("Please select a ministry to edit.");
                return;
            }

            var form = new EditMinistry(selected.Id);
            form.ShowDialog();
            LoadMinistries(); // refresh after editing
        }

        private void DeleteMinistryBtn_Click(object sender, EventArgs e)
        {
            if (MinistriesLsbx.SelectedItem is not MinistryItem selected)
            {
                MessageBox.Show("Please select a ministry to delete.");
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete '{selected.Name}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo);

            if (confirm != DialogResult.Yes)
                return;

            using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnString);
            conn.Open();

            using var cmd = new SqlCommand("DELETE FROM Ministries WHERE Id = @id", conn);
            cmd.Parameters.AddWithValue("@id", selected.Id);
            cmd.ExecuteNonQuery();

            LoadMinistries(); // refresh after deleting
        }
    }

    // Helper class so ListBox shows Name but stores Id
    public class MinistryItem
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public override string ToString() => Name;
    }
}

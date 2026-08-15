using System;
using System.Windows.Forms;
using MemberCrud.Models;
using MemberCrud.Services;

namespace MemberCrud
{
    public partial class AddMinistry : Form
    {
        private readonly MinistryService _ministryService = new();

        public AddMinistry()
        {
            InitializeComponent();

            SaveChangesBtn.Click += SaveChangesBtn_Click;
            CancelBtn.Click += CancelBtn_Click;
        }

        private void SaveChangesBtn_Click(object? sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show(
                    "Please enter both a ministry name and description.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var ministry = new Ministry
            {
                Name = textBox1.Text.Trim(),
                Description = textBox2.Text.Trim()
            };

            try
            {
                _ministryService.AddMinistry(ministry);

                MessageBox.Show(
                    "Ministry added successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "The ministry could not be saved.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CancelBtn_Click(object? sender, EventArgs e)
        {
            // Close without saving
            Close();
        }
    }
}

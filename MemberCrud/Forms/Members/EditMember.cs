using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MemberCrud.Models;
using MemberCrud.Services;



namespace MemberCrud
{
    /// <summary>
    /// Represents the form used to edit an existing church member.
    ///
    /// This form receives a Member object selected from the
    /// MemberManagement form. It displays the current member
    /// information, allows the user to change the information,
    /// and saves the updated values to the database.
    ///
    /// The form uses MemberService to update the member through
    /// Entity Framework Core.
    /// </summary>

    public partial class EditMember : Form
    {
        /// <summary>
        /// Stores the member currently being edited.
        ///
        /// This object contains the original member information
        /// loaded from the database. The form updates this object
        /// before sending it to MemberService.
        /// </summary>

        private readonly Member _member;

        /// <summary>
        /// Service used to update member information in the database.
        ///
        /// MemberService uses Entity Framework Core and
        /// MemberCrudDbContext to communicate with SQL Server.
        /// </summary>


        private readonly MemberService _memberService = new MemberService();
        /// <summary>
        /// Initializes the Edit Member form.
        ///
        /// The selected Member object is received from another form,
        /// stored in the _member field, and displayed in the form
        /// controls so the user can edit the information.
        /// </summary>
        /// <param name="member">
        /// The existing member selected for editing.
        /// </param>

        public EditMember(Member member)
        {
            InitializeComponent();

            _member = member;

            
            comboBox1.Items.Add("Active");
            comboBox1.Items.Add("Inactive");
            comboBox1.Items.Add("Pending");
            comboBox1.Items.Add("Visitor");

          
            comboBox2.Items.AddRange(new string[]
            {
                "Alabama",
                "Alaska",
                "Arizona",
                "Arkansas",
                "California",
                "Colorado",
                "Connecticut",
                "Delaware",
                "Florida",
                "Georgia",
                "Hawaii",
                "Idaho",
                "Illinois",
                "Indiana",
                "Iowa",
                "Kansas",
                "Kentucky",
                "Louisiana",
                "Maine",
                "Maryland",
                "Massachusetts",
                "Michigan",
                "Minnesota",
                "Mississippi",
                "Missouri",
                "Montana",
                "Nebraska",
                "Nevada",
                "New Hampshire",
                "New Jersey",
                "New Mexico",
                "New York",
                "North Carolina",
                "North Dakota",
                "Ohio",
                "Oklahoma",
                "Oregon",
                "Pennsylvania",
                "Rhode Island",
                "South Carolina",
                "South Dakota",
                "Tennessee",
                "Texas",
                "Utah",
                "Vermont",
                "Virginia",
                "Washington",
                "West Virginia",
                "Wisconsin",
                "Wyoming"
            });

            
            dateTimePicker1.MaxDate = DateTime.Today;

            
            LoadMemberInformation();
        }

        
        private void LoadMemberInformation()
        {
            textBox1.Text = _member.FirstName;
            textBox2.Text = _member.LastName;
            textBox3.Text = _member.Phone;
            textBox4.Text = _member.Email;

            comboBox1.SelectedItem = _member.MembershipStatus;

            textBox5.Text = _member.Street;
            textBox6.Text = _member.City;
            textBox7.Text = _member.PostalCode;

            
            dateTimePicker1.Value =
                _member.DateOfBirth.ToDateTime(TimeOnly.MinValue);
        }

       
        private void SaveMemberBtn_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show(
                    "Please enter all required member information.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            
            _member.FirstName = textBox1.Text;
            _member.LastName = textBox2.Text;
            _member.Phone = textBox3.Text;
            _member.Email = textBox4.Text;

            _member.MembershipStatus =
                comboBox1.SelectedItem?.ToString() ?? "Active";

            _member.Street = textBox5.Text;
            _member.City = textBox6.Text;
            _member.PostalCode = textBox7.Text;

            _member.DateOfBirth =
                DateOnly.FromDateTime(dateTimePicker1.Value);

            try
            {
                
                _memberService.UpdateMember(_member);

                MessageBox.Show(
                    "Member updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "The member could not be updated.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CancelMemberBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }
    }
}
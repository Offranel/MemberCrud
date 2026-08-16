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
    /// Service used to retrieve, update, and delete members
    /// from the database.
    ///
    /// The form uses this service instead of communicating
    /// directly with the database.
    /// </summary>
    public partial class MemberManagement : Form
    {
        
        private readonly MemberService _memberService =
            new MemberService();

        
        public MemberManagement()
        {
            InitializeComponent();

            
            AddMemberBtn.Click += AddMemberBtn_Click;
            EditMemberBtn.Click += EditMemberBtn_Click;
            DeleteMemberBtn.Click += DeleteMemberBtn_Click;

            
            LoadMembers();
        }

        
        private void LoadMembers()
        {
            
            AllMembersLsbx.Items.Clear();

            
            var members = _memberService.GetAllMembers();

           
            foreach (Member member in members)
            {
                AllMembersLsbx.Items.Add(member);
            }
        }

        
        private void AddMemberBtn_Click(object? sender, EventArgs e)
        {
            
            AddMember addMemberForm = new AddMember();

            addMemberForm.ShowDialog();

            
            LoadMembers();
        }

        
        private void EditMemberBtn_Click(object? sender, EventArgs e)
        {
            
            if (AllMembersLsbx.SelectedItem is not Member selectedMember)
            {
                MessageBox.Show(
                    "Please select a member to edit.",
                    "No Member Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            
            EditMember editMemberForm =
                new EditMember(selectedMember);

            editMemberForm.ShowDialog();

           
            LoadMembers();
        }

        
        private void DeleteMemberBtn_Click(object? sender, EventArgs e)
        {
            
            if (AllMembersLsbx.SelectedItem is not Member selectedMember)
            {
                MessageBox.Show(
                    "Please select a member to delete.",
                    "No Member Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this member?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                
                _memberService.DeleteMember(selectedMember);

                MessageBox.Show(
                    "Member deleted successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                
                LoadMembers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "The member could not be deleted.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}

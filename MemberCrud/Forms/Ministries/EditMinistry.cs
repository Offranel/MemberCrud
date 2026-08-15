using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MemberCrud.Models;
using MemberCrud.Services;

namespace MemberCrud
{
    public partial class EditMinistry : Form
    {
        private readonly MinistryService _ministryService = new();
        private readonly MemberService _memberService = new();

        // Currently selected ministry id
        private int? _selectedMinistryId;

        public EditMinistry(int id)
        {
            InitializeComponent();

            // Wire up events
            Load += EditMinistry_Load;
            MinistriesLsBx.SelectedIndexChanged += MinistriesLsBx_SelectedIndexChanged;
            AddMemberToMinistryBtn.Click += AddMemberToMinistryBtn_Click;
            RemoveMemberFromMinistryBtn.Click += RemoveMemberFromMinistryBtn_Click;
            SaveChangesBtn.Click += SaveChangesBtn_Click;
            CancelChangesBtn.Click += CancelChangesBtn_Click;
        }

        private void EditMinistry_Load(object? sender, EventArgs e)
        {
            LoadAllMembers();
            LoadMinistries();
        }

        private void LoadAllMembers()
        {
            AllMembersLsBx.Items.Clear();

            try
            {
                var members = _memberService.GetAllMembers();
                foreach (var m in members)
                {
                    AllMembersLsBx.Items.Add(new MemberListItem(m.Id, $"{m.FirstName} {m.LastName}"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load members.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMinistries()
        {
            MinistriesLsBx.Items.Clear();

            try
            {
                var ministries = _ministryService.GetAllMinistries();
                foreach (var m in ministries)
                {
                    MinistriesLsBx.Items.Add(new MinistryItem { Id = m.Id, Name = m.Name });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load ministries.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MinistriesLsBx_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (MinistriesLsBx.SelectedItem is not MinistryItem selected)
            {
                _selectedMinistryId = null;
                return;
            }

            _selectedMinistryId = selected.Id;

            // Load ministry details
            try
            {
                var ministry = _ministryService.GetMinistryById(selected.Id);
                if (ministry != null)
                {
                    textBox1.Text = ministry.Name;
                    textBox2.Text = ministry.Description;
                }

                // Load assigned members
                LoadMembersInMinistry(selected.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load ministry details.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMembersInMinistry(int ministryId)
        {
            MembersLsBx.Items.Clear();

            var members = _ministryService.GetMembersForMinistry(ministryId);
            foreach (var m in members)
            {
                MembersLsBx.Items.Add(new MemberListItem(m.Id, $"{m.FirstName} {m.LastName}"));
            }
        }

        private void AddMemberToMinistryBtn_Click(object? sender, EventArgs e)
        {
            if (_selectedMinistryId == null)
            {
                MessageBox.Show("Select a ministry first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (AllMembersLsBx.SelectedItem is not MemberListItem selectedMember)
            {
                MessageBox.Show("Select a member to add.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Prevent duplicates in the UI
                bool alreadyAssigned = MembersLsBx.Items.Cast<MemberListItem>().Any(x => x.Id == selectedMember.Id);
                if (alreadyAssigned)
                {
                    MessageBox.Show("Member already assigned to this ministry.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                _ministryService.AssignMemberToMinistry(_selectedMinistryId.Value, selectedMember.Id);
                LoadMembersInMinistry(_selectedMinistryId.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add member to ministry.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveMemberFromMinistryBtn_Click(object? sender, EventArgs e)
        {
            if (_selectedMinistryId == null)
            {
                MessageBox.Show("Select a ministry first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MembersLsBx.SelectedItem is not MemberListItem selectedMember)
            {
                MessageBox.Show("Select a member to remove.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                _ministryService.RemoveMemberFromMinistry(_selectedMinistryId.Value, selectedMember.Id);
                LoadMembersInMinistry(_selectedMinistryId.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to remove member from ministry.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveChangesBtn_Click(object? sender, EventArgs e)
        {
            if (_selectedMinistryId == null)
            {
                MessageBox.Show("Select a ministry to save.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var updated = new Ministry
                {
                    Id = _selectedMinistryId.Value,
                    Name = textBox1.Text.Trim(),
                    Description = textBox2.Text.Trim()
                };

                _ministryService.UpdateMinistry(updated);

                MessageBox.Show("Changes saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMinistries();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save changes.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelChangesBtn_Click(object? sender, EventArgs e)
        {
            Close();
        }

        // Simple wrapper for showing members in ListBox while keeping Id
        private class MemberListItem
        {
            public int Id { get; }
            public string Name { get; }

            public MemberListItem(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public override string ToString() => Name;
        }
    }
}

namespace MemberCrud
{
    partial class MemberManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AllMembersLsbx = new ListBox();
            AddMemberBtn = new Button();
            EditMemberBtn = new Button();
            DeleteMemberBtn = new Button();
            SuspendLayout();
            // 
            // AllMembersLsbx
            // 
            AllMembersLsbx.ForeColor = SystemColors.MenuHighlight;
            AllMembersLsbx.FormattingEnabled = true;
            AllMembersLsbx.Location = new Point(100, 71);
            AllMembersLsbx.Margin = new Padding(5);
            AllMembersLsbx.Name = "AllMembersLsbx";
            AllMembersLsbx.Size = new Size(550, 537);
            AllMembersLsbx.TabIndex = 0;
            // 
            // AddMemberBtn
            // 
            AddMemberBtn.Location = new Point(746, 128);
            AddMemberBtn.Margin = new Padding(5);
            AddMemberBtn.Name = "AddMemberBtn";
            AddMemberBtn.Size = new Size(287, 79);
            AddMemberBtn.TabIndex = 1;
            AddMemberBtn.Text = "Add a member";
            AddMemberBtn.UseVisualStyleBackColor = true;
            // 
            // EditMemberBtn
            // 
            EditMemberBtn.Location = new Point(746, 310);
            EditMemberBtn.Margin = new Padding(5);
            EditMemberBtn.Name = "EditMemberBtn";
            EditMemberBtn.Size = new Size(287, 79);
            EditMemberBtn.TabIndex = 2;
            EditMemberBtn.Text = "Edit a member";
            EditMemberBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteMemberBtn
            // 
            DeleteMemberBtn.Location = new Point(746, 494);
            DeleteMemberBtn.Margin = new Padding(5);
            DeleteMemberBtn.Name = "DeleteMemberBtn";
            DeleteMemberBtn.Size = new Size(287, 75);
            DeleteMemberBtn.TabIndex = 3;
            DeleteMemberBtn.Text = "Delete a member";
            DeleteMemberBtn.UseVisualStyleBackColor = true;
            // 
            // MemberManagement
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 738);
            Controls.Add(DeleteMemberBtn);
            Controls.Add(EditMemberBtn);
            Controls.Add(AddMemberBtn);
            Controls.Add(AllMembersLsbx);
            ForeColor = Color.FromArgb(192, 0, 0);
            Margin = new Padding(5);
            Name = "MemberManagement";
            Text = "MemberManagement";
            ResumeLayout(false);
        }

        #endregion

        private ListBox AllMembersLsbx;
        private Button AddMemberBtn;
        private Button EditMemberBtn;
        private Button DeleteMemberBtn;
    }
}
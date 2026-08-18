namespace MemberCrud
{
    partial class EditMinistry
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            MinistriesLsBx = new ListBox();
            MembersLsBx = new ListBox();
            label3 = new Label();
            label4 = new Label();
            AddMemberToMinistryBtn = new Button();
            RemoveMemberFromMinistryBtn = new Button();
            SaveChangesBtn = new Button();
            CancelChangesBtn = new Button();
            label5 = new Label();
            AllMembersLsBx = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(51, 44);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(218, 41);
            label1.TabIndex = 0;
            label1.Text = "Ministry Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(27, 162);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(290, 41);
            label2.TabIndex = 1;
            label2.Text = "Ministry Description:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 90);
            textBox1.Margin = new Padding(5, 5, 5, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 47);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(102, 208);
            textBox2.Margin = new Padding(5, 5, 5, 5);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(426, 73);
            textBox2.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1052, 38);
            groupBox1.Margin = new Padding(5, 5, 5, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 5, 5, 5);
            groupBox1.Size = new Size(641, 379);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ministry Info";
            // 
            // MinistriesLsBx
            // 
            MinistriesLsBx.ForeColor = SystemColors.Highlight;
            MinistriesLsBx.FormattingEnabled = true;
            MinistriesLsBx.Location = new Point(73, 82);
            MinistriesLsBx.Margin = new Padding(5, 5, 5, 5);
            MinistriesLsBx.Name = "MinistriesLsBx";
            MinistriesLsBx.Size = new Size(412, 332);
            MinistriesLsBx.TabIndex = 5;
            // 
            // MembersLsBx
            // 
            MembersLsBx.ForeColor = SystemColors.Highlight;
            MembersLsBx.FormattingEnabled = true;
            MembersLsBx.Location = new Point(73, 553);
            MembersLsBx.Margin = new Padding(5, 5, 5, 5);
            MembersLsBx.Name = "MembersLsBx";
            MembersLsBx.Size = new Size(412, 332);
            MembersLsBx.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(73, 15);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(145, 41);
            label3.TabIndex = 7;
            label3.Text = "Ministries";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(73, 490);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(342, 41);
            label4.TabIndex = 8;
            label4.Text = "Members In the Ministry";
            // 
            // AddMemberToMinistryBtn
            // 
            AddMemberToMinistryBtn.ForeColor = Color.FromArgb(192, 0, 0);
            AddMemberToMinistryBtn.Location = new Point(1052, 490);
            AddMemberToMinistryBtn.Margin = new Padding(5, 5, 5, 5);
            AddMemberToMinistryBtn.Name = "AddMemberToMinistryBtn";
            AddMemberToMinistryBtn.Size = new Size(272, 102);
            AddMemberToMinistryBtn.TabIndex = 9;
            AddMemberToMinistryBtn.Text = "Add Member";
            AddMemberToMinistryBtn.UseVisualStyleBackColor = true;
            // 
            // RemoveMemberFromMinistryBtn
            // 
            RemoveMemberFromMinistryBtn.ForeColor = Color.FromArgb(192, 0, 0);
            RemoveMemberFromMinistryBtn.Location = new Point(1054, 649);
            RemoveMemberFromMinistryBtn.Margin = new Padding(5, 5, 5, 5);
            RemoveMemberFromMinistryBtn.Name = "RemoveMemberFromMinistryBtn";
            RemoveMemberFromMinistryBtn.Size = new Size(272, 102);
            RemoveMemberFromMinistryBtn.TabIndex = 10;
            RemoveMemberFromMinistryBtn.Text = "Remove Member";
            RemoveMemberFromMinistryBtn.UseVisualStyleBackColor = true;
            // 
            // SaveChangesBtn
            // 
            SaveChangesBtn.ForeColor = Color.FromArgb(192, 0, 0);
            SaveChangesBtn.Location = new Point(1421, 490);
            SaveChangesBtn.Margin = new Padding(5, 5, 5, 5);
            SaveChangesBtn.Name = "SaveChangesBtn";
            SaveChangesBtn.Size = new Size(272, 102);
            SaveChangesBtn.TabIndex = 11;
            SaveChangesBtn.Text = "Save Changes";
            SaveChangesBtn.UseVisualStyleBackColor = true;
            // 
            // CancelChangesBtn
            // 
            CancelChangesBtn.ForeColor = Color.FromArgb(192, 0, 0);
            CancelChangesBtn.Location = new Point(1421, 635);
            CancelChangesBtn.Margin = new Padding(5, 5, 5, 5);
            CancelChangesBtn.Name = "CancelChangesBtn";
            CancelChangesBtn.Size = new Size(272, 102);
            CancelChangesBtn.TabIndex = 12;
            CancelChangesBtn.Text = "Cancel";
            CancelChangesBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(604, 38);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(185, 41);
            label5.TabIndex = 13;
            label5.Text = "All Members";
            // 
            // AllMembersLsBx
            // 
            AllMembersLsBx.ForeColor = SystemColors.Highlight;
            AllMembersLsBx.FormattingEnabled = true;
            AllMembersLsBx.Location = new Point(604, 110);
            AllMembersLsBx.Margin = new Padding(5, 5, 5, 5);
            AllMembersLsBx.Name = "AllMembersLsBx";
            AllMembersLsBx.Size = new Size(342, 742);
            AllMembersLsBx.TabIndex = 14;
            // 
            // EditMinistry
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1729, 935);
            Controls.Add(AllMembersLsBx);
            Controls.Add(label5);
            Controls.Add(CancelChangesBtn);
            Controls.Add(SaveChangesBtn);
            Controls.Add(RemoveMemberFromMinistryBtn);
            Controls.Add(AddMemberToMinistryBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(MembersLsBx);
            Controls.Add(MinistriesLsBx);
            Controls.Add(groupBox1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "EditMinistry";
            Text = "Edit Ministry";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private ListBox MinistriesLsBx;
        private ListBox MembersLsBx;
        private Label label3;
        private Label label4;
        private Button AddMemberToMinistryBtn;
        private Button RemoveMemberFromMinistryBtn;
        private Button SaveChangesBtn;
        private Button CancelChangesBtn;
        private Label label5;
        private ListBox AllMembersLsBx;
    }
}
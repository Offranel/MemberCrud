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
            label1.Location = new Point(30, 27);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 0;
            label1.Text = "Ministry Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 99);
            label2.Name = "label2";
            label2.Size = new Size(174, 25);
            label2.TabIndex = 1;
            label2.Text = "Ministry Description:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(60, 127);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(252, 46);
            textBox2.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(SaveChangesBtn);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(619, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(377, 279);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ministry Info";
            // 
            // MinistriesLsBx
            // 
            MinistriesLsBx.FormattingEnabled = true;
            MinistriesLsBx.Location = new Point(43, 50);
            MinistriesLsBx.Name = "MinistriesLsBx";
            MinistriesLsBx.Size = new Size(244, 204);
            MinistriesLsBx.TabIndex = 5;
            // 
            // MembersLsBx
            // 
            MembersLsBx.FormattingEnabled = true;
            MembersLsBx.Location = new Point(43, 337);
            MembersLsBx.Name = "MembersLsBx";
            MembersLsBx.Size = new Size(244, 204);
            MembersLsBx.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 9);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 7;
            label3.Text = "Ministries";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 299);
            label4.Name = "label4";
            label4.Size = new Size(205, 25);
            label4.TabIndex = 8;
            label4.Text = "Members In the Ministry";
            // 
            // AddMemberToMinistryBtn
            // 
            AddMemberToMinistryBtn.Location = new Point(715, 328);
            AddMemberToMinistryBtn.Name = "AddMemberToMinistryBtn";
            AddMemberToMinistryBtn.Size = new Size(160, 62);
            AddMemberToMinistryBtn.TabIndex = 9;
            AddMemberToMinistryBtn.Text = "Add Member";
            AddMemberToMinistryBtn.UseVisualStyleBackColor = true;
            // 
            // RemoveMemberFromMinistryBtn
            // 
            RemoveMemberFromMinistryBtn.Location = new Point(620, 396);
            RemoveMemberFromMinistryBtn.Name = "RemoveMemberFromMinistryBtn";
            RemoveMemberFromMinistryBtn.Size = new Size(160, 62);
            RemoveMemberFromMinistryBtn.TabIndex = 10;
            RemoveMemberFromMinistryBtn.Text = "Remove Member";
            RemoveMemberFromMinistryBtn.UseVisualStyleBackColor = true;
            // 
            // SaveChangesBtn
            // 
            SaveChangesBtn.Location = new Point(96, 195);
            SaveChangesBtn.Name = "SaveChangesBtn";
            SaveChangesBtn.Size = new Size(160, 62);
            SaveChangesBtn.TabIndex = 11;
            SaveChangesBtn.Text = "Save Changes";
            SaveChangesBtn.UseVisualStyleBackColor = true;
            // 
            // CancelChangesBtn
            // 
            CancelChangesBtn.Location = new Point(836, 387);
            CancelChangesBtn.Name = "CancelChangesBtn";
            CancelChangesBtn.Size = new Size(160, 62);
            CancelChangesBtn.TabIndex = 12;
            CancelChangesBtn.Text = "Cancel";
            CancelChangesBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(355, 23);
            label5.Name = "label5";
            label5.Size = new Size(112, 25);
            label5.TabIndex = 13;
            label5.Text = "All Members";
            // 
            // AllMembersLsBx
            // 
            AllMembersLsBx.FormattingEnabled = true;
            AllMembersLsBx.Location = new Point(355, 67);
            AllMembersLsBx.Name = "AllMembersLsBx";
            AllMembersLsBx.Size = new Size(203, 454);
            AllMembersLsBx.TabIndex = 14;
            // 
            // EditMinistry
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 570);
            Controls.Add(AllMembersLsBx);
            Controls.Add(label5);
            Controls.Add(CancelChangesBtn);
            Controls.Add(RemoveMemberFromMinistryBtn);
            Controls.Add(AddMemberToMinistryBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(MembersLsBx);
            Controls.Add(MinistriesLsBx);
            Controls.Add(groupBox1);
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
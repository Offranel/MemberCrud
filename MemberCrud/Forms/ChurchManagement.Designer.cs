namespace MemberCrud
{
    partial class ChurchManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MemberManagementBtn = new Button();
            MinistryManagemetBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // MemberManagementBtn
            // 
            MemberManagementBtn.ForeColor = SystemColors.Highlight;
            MemberManagementBtn.Location = new Point(207, 197);
            MemberManagementBtn.Margin = new Padding(5, 5, 5, 5);
            MemberManagementBtn.Name = "MemberManagementBtn";
            MemberManagementBtn.Size = new Size(502, 169);
            MemberManagementBtn.TabIndex = 0;
            MemberManagementBtn.Text = "Member Management";
            MemberManagementBtn.UseVisualStyleBackColor = true;
            MemberManagementBtn.Click += MemberManagementBtn_Click;
            // 
            // MinistryManagemetBtn
            // 
            MinistryManagemetBtn.ForeColor = SystemColors.Highlight;
            MinistryManagemetBtn.Location = new Point(207, 451);
            MinistryManagemetBtn.Margin = new Padding(5, 5, 5, 5);
            MinistryManagemetBtn.Name = "MinistryManagemetBtn";
            MinistryManagemetBtn.Size = new Size(498, 166);
            MinistryManagemetBtn.TabIndex = 1;
            MinistryManagemetBtn.Text = "Ministry Management";
            MinistryManagemetBtn.UseVisualStyleBackColor = true;
            MinistryManagemetBtn.Click += MinistryManagemetBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(396, 84);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 41);
            label1.TabIndex = 2;
            label1.Text = "Go to:";
            // 
            // ChurchManagement
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 738);
            Controls.Add(label1);
            Controls.Add(MinistryManagemetBtn);
            Controls.Add(MemberManagementBtn);
            Margin = new Padding(5, 5, 5, 5);
            Name = "ChurchManagement";
            Text = "ChurchManagement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MemberManagementBtn;
        private Button MinistryManagemetBtn;
        private Label label1;
    }
}

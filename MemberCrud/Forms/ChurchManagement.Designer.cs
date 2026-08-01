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
            MemberManagementBtn.Location = new Point(122, 120);
            MemberManagementBtn.Name = "MemberManagementBtn";
            MemberManagementBtn.Size = new Size(295, 103);
            MemberManagementBtn.TabIndex = 0;
            MemberManagementBtn.Text = "Member Management";
            MemberManagementBtn.UseVisualStyleBackColor = true;
            // 
            // MinistryManagemetBtn
            // 
            MinistryManagemetBtn.Location = new Point(122, 275);
            MinistryManagemetBtn.Name = "MinistryManagemetBtn";
            MinistryManagemetBtn.Size = new Size(293, 101);
            MinistryManagemetBtn.TabIndex = 1;
            MinistryManagemetBtn.Text = "Ministry Management";
            MinistryManagemetBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(233, 51);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 2;
            label1.Text = "Go to:";
            // 
            // ChurchManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 450);
            Controls.Add(label1);
            Controls.Add(MinistryManagemetBtn);
            Controls.Add(MemberManagementBtn);
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

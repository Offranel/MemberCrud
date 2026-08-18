namespace MemberCrud
{
    partial class MinistryManagement
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
            MinistriesLsbx = new ListBox();
            AddMinistryBtn = new Button();
            EditMinistryBtn = new Button();
            DeleteMinistryBtn = new Button();
            SuspendLayout();
            // 
            // MinistriesLsbx
            // 
            MinistriesLsbx.ForeColor = SystemColors.Highlight;
            MinistriesLsbx.FormattingEnabled = true;
            MinistriesLsbx.Location = new Point(71, 67);
            MinistriesLsbx.Margin = new Padding(5, 5, 5, 5);
            MinistriesLsbx.Name = "MinistriesLsbx";
            MinistriesLsbx.Size = new Size(454, 578);
            MinistriesLsbx.TabIndex = 0;
            // 
            // AddMinistryBtn
            // 
            AddMinistryBtn.ForeColor = Color.FromArgb(192, 0, 0);
            AddMinistryBtn.Location = new Point(634, 141);
            AddMinistryBtn.Margin = new Padding(5, 5, 5, 5);
            AddMinistryBtn.Name = "AddMinistryBtn";
            AddMinistryBtn.Size = new Size(306, 67);
            AddMinistryBtn.TabIndex = 1;
            AddMinistryBtn.Text = "Add Ministry";
            AddMinistryBtn.UseVisualStyleBackColor = true;
            AddMinistryBtn.Click += AddMinistryBtn_Click;
            // 
            // EditMinistryBtn
            // 
            EditMinistryBtn.ForeColor = Color.FromArgb(192, 0, 0);
            EditMinistryBtn.Location = new Point(634, 323);
            EditMinistryBtn.Margin = new Padding(5, 5, 5, 5);
            EditMinistryBtn.Name = "EditMinistryBtn";
            EditMinistryBtn.Size = new Size(306, 67);
            EditMinistryBtn.TabIndex = 2;
            EditMinistryBtn.Text = "Edit Ministry";
            EditMinistryBtn.UseVisualStyleBackColor = true;
            EditMinistryBtn.Click += EditMinistryBtn_Click;
            // 
            // DeleteMinistryBtn
            // 
            DeleteMinistryBtn.ForeColor = Color.FromArgb(192, 0, 0);
            DeleteMinistryBtn.Location = new Point(634, 503);
            DeleteMinistryBtn.Margin = new Padding(5, 5, 5, 5);
            DeleteMinistryBtn.Name = "DeleteMinistryBtn";
            DeleteMinistryBtn.Size = new Size(306, 67);
            DeleteMinistryBtn.TabIndex = 3;
            DeleteMinistryBtn.Text = "Delete Ministry";
            DeleteMinistryBtn.UseVisualStyleBackColor = true;
            DeleteMinistryBtn.Click += DeleteMinistryBtn_Click;
            // 
            // MinistryManagement
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 738);
            Controls.Add(DeleteMinistryBtn);
            Controls.Add(EditMinistryBtn);
            Controls.Add(AddMinistryBtn);
            Controls.Add(MinistriesLsbx);
            Margin = new Padding(5, 5, 5, 5);
            Name = "MinistryManagement";
            Text = "MinistryManagement";
            ResumeLayout(false);
        }

        #endregion

        private ListBox MinistriesLsbx;
        private Button AddMinistryBtn;
        private Button EditMinistryBtn;
        private Button DeleteMinistryBtn;
    }
}
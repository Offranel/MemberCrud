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
            MinistriesLsbx.FormattingEnabled = true;
            MinistriesLsbx.Location = new Point(42, 41);
            MinistriesLsbx.Name = "MinistriesLsbx";
            MinistriesLsbx.Size = new Size(269, 354);
            MinistriesLsbx.TabIndex = 0;
            // 
            // AddMinistryBtn
            // 
            AddMinistryBtn.Location = new Point(373, 86);
            AddMinistryBtn.Name = "AddMinistryBtn";
            AddMinistryBtn.Size = new Size(180, 41);
            AddMinistryBtn.TabIndex = 1;
            AddMinistryBtn.Text = "Add Ministry";
            AddMinistryBtn.UseVisualStyleBackColor = true;
            AddMinistryBtn.Click += AddMinistryBtn_Click;
            // 
            // EditMinistryBtn
            // 
            EditMinistryBtn.Location = new Point(373, 197);
            EditMinistryBtn.Name = "EditMinistryBtn";
            EditMinistryBtn.Size = new Size(180, 41);
            EditMinistryBtn.TabIndex = 2;
            EditMinistryBtn.Text = "Edit Ministry";
            EditMinistryBtn.UseVisualStyleBackColor = true;
            EditMinistryBtn.Click += EditMinistryBtn_Click;
            // 
            // DeleteMinistryBtn
            // 
            DeleteMinistryBtn.Location = new Point(373, 307);
            DeleteMinistryBtn.Name = "DeleteMinistryBtn";
            DeleteMinistryBtn.Size = new Size(180, 41);
            DeleteMinistryBtn.TabIndex = 3;
            DeleteMinistryBtn.Text = "Delete Ministry";
            DeleteMinistryBtn.UseVisualStyleBackColor = true;
            DeleteMinistryBtn.Click += DeleteMinistryBtn_Click;
            // 
            // MinistryManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 450);
            Controls.Add(DeleteMinistryBtn);
            Controls.Add(EditMinistryBtn);
            Controls.Add(AddMinistryBtn);
            Controls.Add(MinistriesLsbx);
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
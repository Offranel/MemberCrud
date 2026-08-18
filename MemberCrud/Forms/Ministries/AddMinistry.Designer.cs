namespace MemberCrud
{
    partial class AddMinistry
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
            SaveChangesBtn = new Button();
            CancelBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(88, 92);
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
            label2.Location = new Point(692, 92);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(290, 41);
            label2.TabIndex = 1;
            label2.Text = "Ministry Description:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(178, 154);
            textBox1.Margin = new Padding(5, 5, 5, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 47);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(818, 154);
            textBox2.Margin = new Padding(5, 5, 5, 5);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(441, 135);
            textBox2.TabIndex = 3;
            // 
            // SaveChangesBtn
            // 
            SaveChangesBtn.ForeColor = Color.FromArgb(192, 0, 0);
            SaveChangesBtn.Location = new Point(41, 241);
            SaveChangesBtn.Margin = new Padding(5, 5, 5, 5);
            SaveChangesBtn.Name = "SaveChangesBtn";
            SaveChangesBtn.Size = new Size(233, 80);
            SaveChangesBtn.TabIndex = 4;
            SaveChangesBtn.Text = "Save Changes";
            SaveChangesBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            CancelBtn.ForeColor = Color.FromArgb(192, 0, 0);
            CancelBtn.Location = new Point(403, 241);
            CancelBtn.Margin = new Padding(5, 5, 5, 5);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(253, 80);
            CancelBtn.TabIndex = 5;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            // 
            // AddMinistry
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 366);
            Controls.Add(CancelBtn);
            Controls.Add(SaveChangesBtn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "AddMinistry";
            Text = "AddMinistry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button SaveChangesBtn;
        private Button CancelBtn;
    }
}
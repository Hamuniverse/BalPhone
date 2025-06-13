namespace BalPhone.Forms
{
    partial class FormSplash
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;

        private void InitializeComponent()
        {
            lblTitle = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTitle.ForeColor = Color.SteelBlue;
            lblTitle.Location = new Point(248, 164);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(280, 74);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BalPhone";
            // 
            // FormSplash
            // 
            BackColor = Color.White;
            ClientSize = new Size(781, 437);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSplash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aplikasi Keren";
            Load += FormSplash_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

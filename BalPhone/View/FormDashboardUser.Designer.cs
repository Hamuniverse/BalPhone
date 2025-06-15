namespace BalPhone.Forms
{
    partial class FormDashboardUser
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSewa;
        private System.Windows.Forms.Button btnRiwayat;
        private System.Windows.Forms.Button btnLogout;

        private void InitializeComponent()
        {
            panelSidebar = new Panel();
            lblTitle = new Label();
            btnSewa = new Button();
            btnRiwayat = new Button();
            btnLogout = new Button();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.LightSteelBlue;
            panelSidebar.Controls.Add(lblTitle);
            panelSidebar.Controls.Add(btnSewa);
            panelSidebar.Controls.Add(btnRiwayat);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(413, 355);
            panelSidebar.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(65, 37);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(180, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "USER PANEL";
            // 
            // btnSewa
            // 
            btnSewa.FlatStyle = FlatStyle.Flat;
            btnSewa.Font = new Font("Segoe UI", 10F);
            btnSewa.Location = new Point(65, 121);
            btnSewa.Name = "btnSewa";
            btnSewa.Size = new Size(180, 40);
            btnSewa.TabIndex = 1;
            btnSewa.Text = "Sewa iPhone";
            btnSewa.Click += btnSewa_Click;
            // 
            // btnRiwayat
            // 
            btnRiwayat.FlatStyle = FlatStyle.Flat;
            btnRiwayat.Font = new Font("Segoe UI", 10F);
            btnRiwayat.Location = new Point(65, 167);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(180, 40);
            btnRiwayat.TabIndex = 2;
            btnRiwayat.Text = "Riwayat Sewa";
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F);
            btnLogout.Location = new Point(65, 283);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(180, 40);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;
            // 
            // FormDashboardUser
            // 
            BackColor = Color.White;
            ClientSize = new Size(307, 355);
            Controls.Add(panelSidebar);
            Name = "FormDashboardUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard User - TI RENT";
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ResumeLayout(false);
        }
    }
}

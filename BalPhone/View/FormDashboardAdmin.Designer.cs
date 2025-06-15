namespace BalPhone.Forms
{
    partial class FormDashboardAdmin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnKelolaIphone;
        private System.Windows.Forms.Button btnVerifikasi;
        private System.Windows.Forms.Button btnPengembalian;
        private System.Windows.Forms.Button btnLogout;

        private void InitializeComponent()
        {
            panelSidebar = new Panel();
            lblTitle = new Label();
            btnKelolaIphone = new Button();
            btnVerifikasi = new Button();
            btnPengembalian = new Button();
            btnLogout = new Button();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.LightSlateGray;
            panelSidebar.Controls.Add(lblTitle);
            panelSidebar.Controls.Add(btnKelolaIphone);
            panelSidebar.Controls.Add(btnVerifikasi);
            panelSidebar.Controls.Add(btnPengembalian);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(359, 512);
            panelSidebar.TabIndex = 0;
            panelSidebar.Paint += panelSidebar_Paint;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(72, 48);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(210, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "PANEL ADMIN";
            // 
            // btnKelolaIphone
            // 
            btnKelolaIphone.FlatStyle = FlatStyle.Flat;
            btnKelolaIphone.Font = new Font("Segoe UI", 10F);
            btnKelolaIphone.Location = new Point(58, 147);
            btnKelolaIphone.Name = "btnKelolaIphone";
            btnKelolaIphone.Size = new Size(242, 58);
            btnKelolaIphone.TabIndex = 1;
            btnKelolaIphone.Text = "Kelola iPhone";
            btnKelolaIphone.Click += btnKelolaIphone_Click;
            // 
            // btnVerifikasi
            // 
            btnVerifikasi.FlatStyle = FlatStyle.Flat;
            btnVerifikasi.Font = new Font("Segoe UI", 10F);
            btnVerifikasi.Location = new Point(58, 224);
            btnVerifikasi.Name = "btnVerifikasi";
            btnVerifikasi.Size = new Size(242, 60);
            btnVerifikasi.TabIndex = 2;
            btnVerifikasi.Text = "Verifikasi Pesanan";
            btnVerifikasi.Click += btnVerifikasi_Click;
            // 
            // btnPengembalian
            // 
            btnPengembalian.FlatStyle = FlatStyle.Flat;
            btnPengembalian.Font = new Font("Segoe UI", 10F);
            btnPengembalian.Location = new Point(58, 306);
            btnPengembalian.Name = "btnPengembalian";
            btnPengembalian.Size = new Size(242, 57);
            btnPengembalian.TabIndex = 3;
            btnPengembalian.Text = "Pengembalian";
            btnPengembalian.Click += btnPengembalian_Click;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F);
            btnLogout.Location = new Point(108, 438);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(141, 46);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;
            // 
            // FormDashboardAdmin
            // 
            BackColor = Color.White;
            ClientSize = new Size(353, 512);
            Controls.Add(panelSidebar);
            Name = "FormDashboardAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard Admin - BalPhone";
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ResumeLayout(false);
        }
    }
}

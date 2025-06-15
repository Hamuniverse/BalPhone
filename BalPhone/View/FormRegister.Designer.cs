namespace BalPhone.Forms
{
    partial class FormRegister
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername, lblPassword, lblEmail, lblTelp, lblKTP;
        private System.Windows.Forms.TextBox txtNama, txtUsername, txtEmail, txtTelp, txtKTP;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBackToLogin;

        private void InitializeComponent()
        {
            panel1 = new Panel();
            txtPassword = new TextBox();
            txtNama = new TextBox();
            lblNama = new Label();
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblTelp = new Label();
            txtTelp = new TextBox();
            lblKTP = new Label();
            txtKTP = new TextBox();
            btnRegister = new Button();
            btnBackToLogin = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtNama);
            panel1.Controls.Add(lblNama);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblTelp);
            panel1.Controls.Add(txtTelp);
            panel1.Controls.Add(lblKTP);
            panel1.Controls.Add(txtKTP);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(btnBackToLogin);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(720, 415);
            panel1.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(186, 351);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 31);
            txtPassword.TabIndex = 15;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(186, 88);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(200, 31);
            txtNama.TabIndex = 14;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(40, 91);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(59, 25);
            lblNama.TabIndex = 13;
            lblNama.Text = "Nama";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(253, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(256, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Buat Akun Baru";
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(40, 301);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 23);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(186, 298);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 31);
            txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(40, 351);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 23);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(40, 242);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(186, 239);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 31);
            txtEmail.TabIndex = 6;
            // 
            // lblTelp
            // 
            lblTelp.Location = new Point(40, 192);
            lblTelp.Name = "lblTelp";
            lblTelp.Size = new Size(100, 23);
            lblTelp.TabIndex = 7;
            lblTelp.Text = "No Telepon:";
            // 
            // txtTelp
            // 
            txtTelp.Location = new Point(186, 189);
            txtTelp.Name = "txtTelp";
            txtTelp.Size = new Size(200, 31);
            txtTelp.TabIndex = 8;
            // 
            // lblKTP
            // 
            lblKTP.Location = new Point(40, 138);
            lblKTP.Name = "lblKTP";
            lblKTP.Size = new Size(100, 23);
            lblKTP.TabIndex = 9;
            lblKTP.Text = "No KTP:";
            // 
            // txtKTP
            // 
            txtKTP.Location = new Point(186, 135);
            txtKTP.Name = "txtKTP";
            txtKTP.Size = new Size(200, 31);
            txtKTP.TabIndex = 10;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(0, 120, 215);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(424, 219);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(250, 35);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Daftar";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.FlatAppearance.BorderSize = 0;
            btnBackToLogin.FlatStyle = FlatStyle.Flat;
            btnBackToLogin.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            btnBackToLogin.ForeColor = Color.DimGray;
            btnBackToLogin.Location = new Point(453, 260);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(202, 36);
            btnBackToLogin.TabIndex = 12;
            btnBackToLogin.Text = "Sudah punya akun?";
            btnBackToLogin.Click += btnBackToLogin_Click;
            // 
            // FormRegister
            // 
            BackColor = Color.White;
            ClientSize = new Size(720, 415);
            Controls.Add(panel1);
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register - BalPhone";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }
        private Label lblNama;
        private TextBox txtPassword;
    }
}

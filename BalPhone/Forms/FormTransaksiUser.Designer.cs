namespace BalPhone.Forms
{
    partial class FormTransaksiUser
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblIphone, lblJumlah, lblHari, lblTanggal;
        private System.Windows.Forms.ComboBox comboBoxIphone;
        private System.Windows.Forms.TextBox txtJumlah, txtJumlahHari, txtTglKembali;
        private System.Windows.Forms.Button btnSewa, btnRiwayat;

        private void InitializeComponent()
        {
            lblIphone = new Label();
            lblJumlah = new Label();
            lblHari = new Label();
            lblTanggal = new Label();
            comboBoxIphone = new ComboBox();
            txtJumlah = new TextBox();
            txtJumlahHari = new TextBox();
            txtTglKembali = new TextBox();
            btnSewa = new Button();
            btnRiwayat = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblIphone
            // 
            lblIphone.Location = new Point(30, 30);
            lblIphone.Name = "lblIphone";
            lblIphone.Size = new Size(100, 23);
            lblIphone.TabIndex = 0;
            lblIphone.Text = "Pilih iPhone:";
            // 
            // lblJumlah
            // 
            lblJumlah.Location = new Point(30, 70);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(100, 23);
            lblJumlah.TabIndex = 2;
            lblJumlah.Text = "Jumlah Unit:";
            // 
            // lblHari
            // 
            lblHari.Location = new Point(30, 110);
            lblHari.Name = "lblHari";
            lblHari.Size = new Size(100, 23);
            lblHari.TabIndex = 4;
            lblHari.Text = "Durasi Sewa (hari):";
            // 
            // lblTanggal
            // 
            lblTanggal.Location = new Point(30, 150);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(100, 23);
            lblTanggal.TabIndex = 6;
            lblTanggal.Text = "Tanggal Kembali:";
            // 
            // comboBoxIphone
            // 
            comboBoxIphone.Location = new Point(160, 30);
            comboBoxIphone.Name = "comboBoxIphone";
            comboBoxIphone.Size = new Size(200, 33);
            comboBoxIphone.TabIndex = 1;
            // 
            // txtJumlah
            // 
            txtJumlah.Location = new Point(160, 70);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(200, 31);
            txtJumlah.TabIndex = 3;
            // 
            // txtJumlahHari
            // 
            txtJumlahHari.Location = new Point(160, 110);
            txtJumlahHari.Name = "txtJumlahHari";
            txtJumlahHari.Size = new Size(60, 31);
            txtJumlahHari.TabIndex = 5;
            // 
            // txtTglKembali
            // 
            txtTglKembali.Location = new Point(160, 150);
            txtTglKembali.Name = "txtTglKembali";
            txtTglKembali.Size = new Size(200, 31);
            txtTglKembali.TabIndex = 7;
            // 
            // btnSewa
            // 
            btnSewa.BackColor = Color.MediumSeaGreen;
            btnSewa.FlatStyle = FlatStyle.Flat;
            btnSewa.ForeColor = Color.White;
            btnSewa.Location = new Point(30, 200);
            btnSewa.Name = "btnSewa";
            btnSewa.Size = new Size(150, 35);
            btnSewa.TabIndex = 8;
            btnSewa.Text = "Sewa Sekarang";
            btnSewa.UseVisualStyleBackColor = false;
            btnSewa.Click += btnSewa_Click;
            // 
            // btnRiwayat
            // 
            btnRiwayat.BackColor = Color.SteelBlue;
            btnRiwayat.FlatStyle = FlatStyle.Flat;
            btnRiwayat.ForeColor = Color.White;
            btnRiwayat.Location = new Point(210, 200);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(150, 35);
            btnRiwayat.TabIndex = 9;
            btnRiwayat.Text = "Lihat Riwayat";
            btnRiwayat.UseVisualStyleBackColor = false;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 116);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 10;
            label1.Text = "Hari";
            // 
            // FormTransaksiUser
            // 
            BackColor = Color.White;
            ClientSize = new Size(420, 256);
            Controls.Add(label1);
            Controls.Add(lblIphone);
            Controls.Add(comboBoxIphone);
            Controls.Add(lblJumlah);
            Controls.Add(txtJumlah);
            Controls.Add(lblHari);
            Controls.Add(txtJumlahHari);
            Controls.Add(lblTanggal);
            Controls.Add(txtTglKembali);
            Controls.Add(btnSewa);
            Controls.Add(btnRiwayat);
            Name = "FormTransaksiUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sewa iPhone";
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
    }
}

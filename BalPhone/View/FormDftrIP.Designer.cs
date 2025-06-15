namespace BalPhone.Forms
{
    partial class FormDftrIP
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSeri;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.TextBox txtSeri;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.DataGridView dataGridView1;

        private void InitializeComponent()
        {
            lblSeri = new Label();
            lblHarga = new Label();
            lblStok = new Label();
            lblDeskripsi = new Label();
            txtSeri = new TextBox();
            txtHarga = new TextBox();
            txtStok = new TextBox();
            txtDeskripsi = new TextBox();
            btnTambah = new Button();
            btnUbah = new Button();
            btnHapus = new Button();
            dataGridView1 = new DataGridView();
            btnKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblSeri
            // 
            lblSeri.Location = new Point(30, 30);
            lblSeri.Name = "lblSeri";
            lblSeri.Size = new Size(100, 23);
            lblSeri.TabIndex = 0;
            lblSeri.Text = "Seri iPhone:";
            // 
            // lblHarga
            // 
            lblHarga.Location = new Point(30, 70);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(100, 23);
            lblHarga.TabIndex = 2;
            lblHarga.Text = "Harga Sewa/Hari:";
            // 
            // lblStok
            // 
            lblStok.Location = new Point(30, 110);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(100, 23);
            lblStok.TabIndex = 4;
            lblStok.Text = "Stok:";
            // 
            // lblDeskripsi
            // 
            lblDeskripsi.Location = new Point(30, 150);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(100, 23);
            lblDeskripsi.TabIndex = 6;
            lblDeskripsi.Text = "Deskripsi:";
            // 
            // txtSeri
            // 
            txtSeri.Location = new Point(150, 30);
            txtSeri.Name = "txtSeri";
            txtSeri.Size = new Size(300, 31);
            txtSeri.TabIndex = 1;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(150, 70);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(300, 31);
            txtHarga.TabIndex = 3;
            // 
            // txtStok
            // 
            txtStok.Location = new Point(150, 110);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(300, 31);
            txtStok.TabIndex = 5;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(150, 150);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(300, 60);
            txtDeskripsi.TabIndex = 7;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(480, 30);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(100, 30);
            btnTambah.TabIndex = 8;
            btnTambah.Text = "Tambah";
            btnTambah.Click += btnTambah_Click;
            // 
            // btnUbah
            // 
            btnUbah.Location = new Point(480, 70);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(100, 30);
            btnUbah.TabIndex = 9;
            btnUbah.Text = "Ubah";
            btnUbah.Click += btnUbah_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(480, 110);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(100, 30);
            btnHapus.TabIndex = 10;
            btnHapus.Text = "Hapus";
            btnHapus.Click += btnHapus_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.Location = new Point(30, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(660, 240);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(480, 176);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(100, 34);
            btnKembali.TabIndex = 12;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // FormDftrIP
            // 
            BackColor = Color.White;
            ClientSize = new Size(720, 500);
            Controls.Add(btnKembali);
            Controls.Add(lblSeri);
            Controls.Add(txtSeri);
            Controls.Add(lblHarga);
            Controls.Add(txtHarga);
            Controls.Add(lblStok);
            Controls.Add(txtStok);
            Controls.Add(lblDeskripsi);
            Controls.Add(txtDeskripsi);
            Controls.Add(btnTambah);
            Controls.Add(btnUbah);
            Controls.Add(btnHapus);
            Controls.Add(dataGridView1);
            Name = "FormDftrIP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kelola Daftar iPhone";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Button btnKembali;
    }
}

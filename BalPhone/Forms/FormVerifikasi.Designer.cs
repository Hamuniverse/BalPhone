namespace BalPhone.Forms
{
    partial class FormVerifikasi
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVerifikasi;

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnVerifikasi = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.Location = new Point(20, 20);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(700, 350);
            dataGridView1.TabIndex = 0;
            // 
            // btnVerifikasi
            // 
            btnVerifikasi.BackColor = Color.SeaGreen;
            btnVerifikasi.FlatStyle = FlatStyle.Flat;
            btnVerifikasi.ForeColor = Color.White;
            btnVerifikasi.Location = new Point(20, 390);
            btnVerifikasi.Name = "btnVerifikasi";
            btnVerifikasi.Size = new Size(200, 35);
            btnVerifikasi.TabIndex = 1;
            btnVerifikasi.Text = "Verifikasi Pembayaran";
            btnVerifikasi.UseVisualStyleBackColor = false;
            btnVerifikasi.Click += btnVerifikasi_Click;
            // 
            // button1
            // 
            button1.Location = new Point(608, 390);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormVerifikasi
            // 
            BackColor = Color.White;
            ClientSize = new Size(750, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(btnVerifikasi);
            Name = "FormVerifikasi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Verifikasi Pembayaran";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }
        private Button button1;
    }
}

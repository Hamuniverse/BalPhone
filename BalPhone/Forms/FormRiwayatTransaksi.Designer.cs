namespace BalPhone.Forms
{
    partial class FormRiwayatTransaksi
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKembali;

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.Location = new Point(20, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(700, 350);
            dataGridView1.TabIndex = 0;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.SteelBlue;
            btnKembali.FlatStyle = FlatStyle.Flat;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(20, 390);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(115, 37);
            btnKembali.TabIndex = 1;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // FormRiwayatTransaksi
            // 
            BackColor = Color.White;
            ClientSize = new Size(750, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnKembali);
            Name = "FormRiwayatTransaksi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Riwayat Transaksi Anda";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }
    }
}

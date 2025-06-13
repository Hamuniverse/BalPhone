namespace BalPhone.Forms
{
    partial class FormPengembalian
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTandaiKembali;

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnTandaiKembali = new Button();
            btnKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
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
            // btnTandaiKembali
            // 
            btnTandaiKembali.BackColor = Color.DarkOliveGreen;
            btnTandaiKembali.FlatStyle = FlatStyle.Flat;
            btnTandaiKembali.ForeColor = Color.White;
            btnTandaiKembali.Location = new Point(20, 390);
            btnTandaiKembali.Name = "btnTandaiKembali";
            btnTandaiKembali.Size = new Size(196, 37);
            btnTandaiKembali.TabIndex = 1;
            btnTandaiKembali.Text = "Tandai Dikembalikan";
            btnTandaiKembali.UseVisualStyleBackColor = false;
            btnTandaiKembali.Click += btnTandaiKembali_Click;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(608, 390);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(112, 34);
            btnKembali.TabIndex = 2;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // FormPengembalian
            // 
            BackColor = Color.White;
            ClientSize = new Size(750, 450);
            Controls.Add(btnKembali);
            Controls.Add(dataGridView1);
            Controls.Add(btnTandaiKembali);
            Name = "FormPengembalian";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pengembalian Barang";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }
        private Button btnKembali;
    }
}
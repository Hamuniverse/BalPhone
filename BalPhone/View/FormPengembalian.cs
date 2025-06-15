using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using BalPhone.Controllers;

namespace BalPhone.Forms
{
    public partial class FormPengembalian : Form
    {
        PengembalianController pengembalianController = new PengembalianController();

        public FormPengembalian()
        {
            InitializeComponent();
            LoadTransaksiBelumKembali();
        }

        private void LoadTransaksiBelumKembali()
        {
            try
            {
                var dt = pengembalianController.GetBelumDikembalikan();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }


        private void btnTandaiKembali_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih transaksi yang ingin ditandai dikembalikan.");
                return;
            }

            int transaksiId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["transaksi_ID"].Value);
            bool success = pengembalianController.TandaiDikembalikan(transaksiId);

            if (success)
            {
                MessageBox.Show("Pengembalian berhasil dicatat!");
                LoadTransaksiBelumKembali();
            }
            else
            {
                MessageBox.Show("Gagal mencatat pengembalian.");
            }
        }


        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
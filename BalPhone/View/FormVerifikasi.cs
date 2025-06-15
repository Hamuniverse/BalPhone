using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BalPhone.Controllers;


namespace BalPhone.Forms
{
    public partial class FormVerifikasi : Form
    {
        VerifikasiController verifikasiController = new VerifikasiController();
        int selectedTransaksiId = -1;

        public FormVerifikasi()
        {
            InitializeComponent();
            LoadPendingTransaksi();
        }

        private void LoadPendingTransaksi()
        {
            try
            {
                var dt = verifikasiController.GetPendingTransaksi();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private void btnVerifikasi_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih salah satu transaksi.");
                return;
            }

            int transaksiId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["transaksi_ID"].Value);
            bool success = verifikasiController.VerifikasiPembayaran(transaksiId);

            if (success)
            {
                MessageBox.Show("Transaksi berhasil diverifikasi!");
                LoadPendingTransaksi();
            }
            else
            {
                MessageBox.Show("Gagal memverifikasi transaksi.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
using BalPhone;
using BalPhone.Models;
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
    public partial class FormRiwayatTransaksi : Form
    {
        RiwayatTransaksiController riwayatController = new RiwayatTransaksiController();

        public FormRiwayatTransaksi()
        {
            InitializeComponent();
            LoadRiwayat();
        }

        private void LoadRiwayat()
        {
            try
            {
                var dt = riwayatController.GetRiwayatUser(Session.Email);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat riwayat: " + ex.Message);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
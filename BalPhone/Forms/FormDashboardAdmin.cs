using BalPhone.Forms;
using BalPhone.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalPhone.Forms
{
    public partial class FormDashboardAdmin : Form
    {
        public FormDashboardAdmin()
        {
            InitializeComponent();
        }

        private void btnKelolaIphone_Click(object sender, EventArgs e)
        {
            FormDftrIP form = new FormDftrIP(); // form daftar iPhone (CRUD)
            form.ShowDialog();
        }

        private void btnVerifikasi_Click(object sender, EventArgs e)
        {
            FormVerifikasi form = new FormVerifikasi(); // form verifikasi pesanan user
            form.ShowDialog();
        }

        private void btnPengembalian_Click(object sender, EventArgs e)
        {
            FormPengembalian form = new FormPengembalian(); // form pengembalian barang
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormLogin login = new FormLogin();
                login.Show();
            }
        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
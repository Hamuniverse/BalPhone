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
using Npgsql;

namespace BalPhone.Forms
{
    public partial class FormDashboardUser : Form
    {
        public FormDashboardUser()
        {
            InitializeComponent();
        }

        private void btnSewa_Click(object sender, EventArgs e)
        {
            FormTransaksiUser form = new FormTransaksiUser();
            form.ShowDialog();
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            FormRiwayatTransaksi form = new FormRiwayatTransaksi();
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin ingin logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                new FormLogin().Show();
            }
        }
    }
}

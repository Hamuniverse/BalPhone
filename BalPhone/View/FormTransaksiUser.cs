using Npgsql;
using System;
using BalPhone.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using BalPhone.Controllers;

namespace BalPhone.Forms
{
    public partial class FormTransaksiUser : Form
    {
        private TransaksiController transaksiController = new TransaksiController();

        public FormTransaksiUser()
        {
            InitializeComponent();
            LoadIphoneList();
        }

        private void LoadIphoneList()
        {
            try
            {
                comboBoxIphone.Items.Clear();
                var list = transaksiController.GetAvailableIphones();
                foreach (var item in list)
                {
                    comboBoxIphone.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat daftar iPhone: " + ex.Message);
            }
        }

        private void btnSewa_Click(object sender, EventArgs e)
        {
            if (comboBoxIphone.SelectedItem == null ||
                !int.TryParse(txtJumlah.Text, out int jumlah) ||
                !int.TryParse(txtJumlahHari.Text, out int hari))
            {
                MessageBox.Show("Isi semua data dengan benar.");
                return;
            }

            var selected = (ComboBoxItem)comboBoxIphone.SelectedItem;

            var transaksi = new Transaksi
            {
                Email = Session.Email,
                NoKTP = Session.NoKTP,
                NoTelp = Session.NoTelp,
                WaktuPemesanan = DateTime.Now,
                StatusPembayaran = "pending"
            };

            var detail = new DetailTransaksi
            {
                IphoneId = selected.Value,
                Jumlah = jumlah,
                JumlahHari = hari
            };

            bool success = transaksiController.BuatTransaksi(transaksi, detail);
            if (success)
            {
                MessageBox.Show("Transaksi berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtJumlah.Text = "";
                txtJumlahHari.Text = "";
                txtTglKembali.Text = "";
            }
            else
            {
                MessageBox.Show("Transaksi gagal. Periksa stok atau data!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            FormRiwayatTransaksi riwayat = new FormRiwayatTransaksi();
            riwayat.ShowDialog();
        }
    }
}
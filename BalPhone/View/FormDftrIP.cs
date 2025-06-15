using BalPhone.Controllers;
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


namespace BalPhone.Forms
{
    public partial class FormDftrIP : Form
    {
        IphoneController controller = new IphoneController();
        int selectedId = -1;

        public FormDftrIP()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var list = controller.GetAll();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data: " + ex.Message);
            }
        }

        private void ClearInput()
        {
            txtSeri.Text = "";
            txtHarga.Text = "";
            txtStok.Text = "";
            txtDeskripsi.Text = "";
            selectedId = -1;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtSeri.Text == "" || txtHarga.Text == "" || txtStok.Text == "")
            {
                MessageBox.Show("Isi semua kolom.");
                return;
            }

            var iphone = new Iphone
            {
                Seri = txtSeri.Text,
                HargaSewa = int.Parse(txtHarga.Text),
                Stok = int.Parse(txtStok.Text),
                Deskripsi = txtDeskripsi.Text
            };

            try
            {
                controller.Insert(iphone);
                LoadData();
                ClearInput();
                MessageBox.Show("Data berhasil ditambahkan.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal tambah data: " + ex.Message);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Pilih data dari tabel.");
                return;
            }

            var iphone = new Iphone
            {
                Id = selectedId,
                Seri = txtSeri.Text,
                HargaSewa = int.Parse(txtHarga.Text),
                Stok = int.Parse(txtStok.Text),
                Deskripsi = txtDeskripsi.Text
            };

            try
            {
                controller.Update(iphone);
                LoadData();
                ClearInput();
                MessageBox.Show("Data berhasil diubah.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal ubah data: " + ex.Message);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Pilih data yang ingin dihapus.");
                return;
            }

            var confirm = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    controller.Delete(selectedId);
                    LoadData();
                    ClearInput();
                    MessageBox.Show("Data berhasil dihapus.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal hapus data: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex].DataBoundItem as Iphone;
                if (row != null)
                {
                    selectedId = row.Id;
                    txtSeri.Text = row.Seri;
                    txtHarga.Text = row.HargaSewa.ToString();
                    txtStok.Text = row.Stok.ToString();
                    txtDeskripsi.Text = row.Deskripsi;
                }
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
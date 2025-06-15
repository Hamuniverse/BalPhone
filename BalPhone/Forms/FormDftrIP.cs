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
    public partial class FormDftrIP : Form
    {
        string connStr = "Host=localhost;Username=postgres;Password=021204;Database=BalPhone";
        NpgsqlConnection conn;

        int selectedId = -1;

        public FormDftrIP()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connStr);
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                conn.Open();
                var da = new NpgsqlDataAdapter("SELECT dftr_ip_id, seri_hp, harga_sewa, stok, deskripsi FROM dftr_ip ORDER BY dftr_ip_id ASC", conn);
                var dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
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

            try
            {
                conn.Open();
                var cmd = new NpgsqlCommand("INSERT INTO dftr_ip (seri_hp, harga_sewa, stok, deskripsi) VALUES (@seri, @harga, @stok, @desc)", conn);
                cmd.Parameters.AddWithValue("@seri", txtSeri.Text);
                cmd.Parameters.AddWithValue("@harga", Convert.ToInt32(txtHarga.Text));
                cmd.Parameters.AddWithValue("@stok", Convert.ToInt32(txtStok.Text));
                cmd.Parameters.AddWithValue("@desc", txtDeskripsi.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                LoadData();
                ClearInput();
                MessageBox.Show("Data berhasil ditambahkan.");
            }
            catch (Exception ex)
            {
                conn.Close();
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

            try
            {
                conn.Open();
                var cmd = new NpgsqlCommand("UPDATE dftr_ip SET seri_hp=@seri, harga_sewa=@harga, stok=@stok, deskripsi=@desc WHERE dftr_ip_id=@id", conn);
                cmd.Parameters.AddWithValue("@seri", txtSeri.Text);
                cmd.Parameters.AddWithValue("@harga", Convert.ToInt32(txtHarga.Text));
                cmd.Parameters.AddWithValue("@stok", Convert.ToInt32(txtStok.Text));
                cmd.Parameters.AddWithValue("@desc", txtDeskripsi.Text);
                cmd.Parameters.AddWithValue("@id", selectedId);
                cmd.ExecuteNonQuery();
                conn.Close();

                LoadData();
                ClearInput();
                MessageBox.Show("Data berhasil diubah.");
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Gagal ubah data: " + ex.Message);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Pilih data dari tabel.");
                return;
            }

            var confirm = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            try
            {
                conn.Open();
                var cmd = new NpgsqlCommand("DELETE FROM dftr_ip WHERE dftr_ip_id=@id", conn);
                cmd.Parameters.AddWithValue("@id", selectedId);
                cmd.ExecuteNonQuery();
                conn.Close();

                LoadData();
                ClearInput();
                MessageBox.Show("Data berhasil dihapus.");
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Gagal hapus data: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["dftr_ip_id"].Value);
                txtSeri.Text = row.Cells["seri_hp"].Value.ToString();
                txtHarga.Text = row.Cells["harga_sewa"].Value.ToString();
                txtStok.Text = row.Cells["stok"].Value.ToString();
                txtDeskripsi.Text = row.Cells["deskripsi"].Value.ToString();
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
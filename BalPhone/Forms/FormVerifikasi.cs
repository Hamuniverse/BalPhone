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
    public partial class FormVerifikasi : Form
    {
        string connStr = "Host=localhost;Username=postgres;Password=021204;Database=tirent";
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
                using (var conn = new NpgsqlConnection(connStr))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            t.transaksi_ID,
                            u.username,
                            i.seri_hp,
                            d.jumlah_pesanan,
                            d.durasi_hari,
                            (i.harga_sewa * d.jumlah_pesanan * d.durasi_hari) AS total_harga,
                            t.status_pembayaran
                        FROM transaksi t
                        JOIN userr u ON t.userr_email = u.email
                        JOIN dtl_trnsksi d ON t.transaksi_ID = d.transaksi_transaksi_ID
                        JOIN dftr_ip i ON d.dftr_ip_dftr_ip_ID = i.dftr_ip_ID
                        WHERE t.status_pembayaran = 'pending'
                        ORDER BY t.waktu_pemesanan ASC";

                    var da = new NpgsqlDataAdapter(query, conn);
                    var dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }

                selectedTransaksiId = -1;
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

            selectedTransaksiId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["transaksi_ID"].Value);

            try
            {
                using (var conn = new NpgsqlConnection(connStr))
                {
                    conn.Open();
                    var cmd = new NpgsqlCommand("UPDATE transaksi SET status_pembayaran = 'sudah dibayar' WHERE transaksi_ID = @id", conn);
                    cmd.Parameters.AddWithValue("@id", selectedTransaksiId);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Transaksi berhasil diverifikasi!");
                LoadPendingTransaksi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memverifikasi: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
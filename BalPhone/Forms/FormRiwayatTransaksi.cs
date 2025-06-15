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

namespace BalPhone.Forms
{
    public partial class FormRiwayatTransaksi : Form
    {
        string connStr = "Host=localhost;Username=postgres;Password=021204;Database=BalPhone";

        public FormRiwayatTransaksi()
        {
            InitializeComponent();
            LoadRiwayat();
        }

        private void LoadRiwayat()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connStr))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            i.seri_hp AS ""iPhone"",
                            d.jumlah_pesanan AS ""Jumlah"",
                            d.durasi_hari AS ""Durasi (hari)"",
                            (i.harga_sewa * d.jumlah_pesanan * d.durasi_hari) AS ""Total Harga (Rp)""
                        FROM transaksi t
                        JOIN dtl_trnsksi d ON t.transaksi_ID = d.transaksi_transaksi_ID
                        JOIN dftr_ip i ON d.dftr_ip_dftr_ip_ID = i.dftr_ip_ID
                        WHERE t.userr_email = @email
                        ORDER BY t.waktu_pemesanan DESC";

                    using (var da = new NpgsqlDataAdapter(query, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@email", Session.Email);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
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
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
    public partial class FormPengembalian : Form
    {
        string connStr = "Host=localhost;Username=postgres;Password=021204;Database=tirent";

        public FormPengembalian()
        {
            InitializeComponent();
            LoadTransaksiBelumKembali();
        }

        private void LoadTransaksiBelumKembali()
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
                            (i.harga_sewa * d.jumlah_pesanan * d.durasi_hari) AS total_harga
                        FROM transaksi t
                        JOIN userr u ON t.userr_email = u.email
                        JOIN dtl_trnsksi d ON t.transaksi_ID = d.transaksi_transaksi_ID
                        JOIN dftr_ip i ON d.dftr_ip_dftr_ip_ID = i.dftr_ip_ID
                        WHERE NOT EXISTS (
                            SELECT 1 FROM pengembalian p 
                            WHERE p.transaksi_transaksi_id = t.transaksi_ID
                        )";

                    var da = new NpgsqlDataAdapter(query, conn);
                    var dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
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

            try
            {
                using (var conn = new NpgsqlConnection(connStr))
                {
                    conn.Open();

                    string query = "INSERT INTO pengembalian (sts_pngmbln, tgl_pngmblian, transaksi_transaksi_id) " +
                                   "VALUES ('dikembalikan', @tgl, @id)";
                    var cmd = new NpgsqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@tgl", DateTime.Now);
                    cmd.Parameters.AddWithValue("@id", transaksiId);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                }

                MessageBox.Show("Status pengembalian berhasil diperbarui!");
                LoadTransaksiBelumKembali();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menandai pengembalian: " + ex.Message);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalPhone.Controllers
{
    public class VerifikasiController
    {
        private readonly string connStr = "Host=localhost;Username=postgres;Password=021204;Database=BalPhone";

        public DataTable GetPendingTransaksi()
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
                return dt;
            }
        }

        public bool VerifikasiPembayaran(int transaksiId)
        {
            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("UPDATE transaksi SET status_pembayaran = 'sudah dibayar' WHERE transaksi_ID = @id", conn);
                cmd.Parameters.AddWithValue("@id", transaksiId);
                int affected = cmd.ExecuteNonQuery();
                return affected > 0;
            }
        }
    }
}

using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalPhone.Controllers
{
    public class RiwayatTransaksiController
    {
        private readonly string connStr = "Host=localhost;Username=postgres;Password=021204;Database=BalPhone";

        public DataTable GetRiwayatUser(string email)
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

                var da = new NpgsqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@email", email);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
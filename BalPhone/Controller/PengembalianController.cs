using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalPhone.Controllers
{
    public class PengembalianController
    {
        private readonly string connStr = "Host=localhost;Username=postgres;Password=021204;Database=BalPhone";

        public DataTable GetBelumDikembalikan()
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
                return dt;
            }
        }

        public bool TandaiDikembalikan(int transaksiId)
        {
            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string insert = @"
                    INSERT INTO pengembalian (sts_pngmbln, tgl_pngmblian, transaksi_transaksi_id)
                    VALUES ('dikembalikan', @tgl, @id)";
                var cmd = new NpgsqlCommand(insert, conn);
                cmd.Parameters.AddWithValue("@tgl", DateTime.Now);
                cmd.Parameters.AddWithValue("@id", transaksiId);
                int affected = cmd.ExecuteNonQuery();
                return affected > 0;
            }
        }
    }
}

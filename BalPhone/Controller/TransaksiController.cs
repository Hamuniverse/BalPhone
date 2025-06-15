using BalPhone.Forms;
using BalPhone.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalPhone.Controllers
{
    public class TransaksiController
    {
        private readonly string connStr = "Host=localhost;Username=postgres;Password=021204;Database=BalPhone";

        public bool BuatTransaksi(Transaksi transaksi, DetailTransaksi detail)
        {
            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();

                // Ambil harga dan stok iPhone
                var cmdIphone = new NpgsqlCommand("SELECT harga_sewa, stok FROM dftr_ip WHERE dftr_ip_ID = @id", conn);
                cmdIphone.Parameters.AddWithValue("@id", detail.IphoneId);
                var reader = cmdIphone.ExecuteReader();

                if (!reader.Read()) return false;

                int harga = reader.GetInt32(0);
                int stok = reader.GetInt32(1);
                reader.Close();

                if (detail.Jumlah > stok) return false;

                // Insert transaksi
                string insertTrans = @"
                    INSERT INTO transaksi (waktu_pemesanan, userr_no_telp, userr_email, userr_no_ktp, status_pembayaran)
                    VALUES (@waktu, @telp, @email, @ktp, @status)
                    RETURNING transaksi_ID";
                var cmdTrans = new NpgsqlCommand(insertTrans, conn);
                cmdTrans.Parameters.AddWithValue("@waktu", transaksi.WaktuPemesanan);
                cmdTrans.Parameters.AddWithValue("@telp", transaksi.NoTelp);
                cmdTrans.Parameters.AddWithValue("@email", transaksi.Email);
                cmdTrans.Parameters.AddWithValue("@ktp", transaksi.NoKTP);
                cmdTrans.Parameters.AddWithValue("@status", transaksi.StatusPembayaran);
                int transaksiId = (int)cmdTrans.ExecuteScalar();

                // Insert detail transaksi
                var cmdDetail = new NpgsqlCommand(@"
                    INSERT INTO dtl_trnsksi (jumlah_pesanan, durasi_hari, transaksi_transaksi_ID, dftr_ip_dftr_ip_ID)
                    VALUES (@jumlah, @hari, @transId, @ipId)", conn);
                cmdDetail.Parameters.AddWithValue("@jumlah", detail.Jumlah);
                cmdDetail.Parameters.AddWithValue("@hari", detail.JumlahHari);
                cmdDetail.Parameters.AddWithValue("@transId", transaksiId);
                cmdDetail.Parameters.AddWithValue("@ipId", detail.IphoneId);
                cmdDetail.ExecuteNonQuery();

                // Update stok iPhone
                var cmdStok = new NpgsqlCommand("UPDATE dftr_ip SET stok = stok - @jumlah WHERE dftr_ip_ID = @id", conn);
                cmdStok.Parameters.AddWithValue("@jumlah", detail.Jumlah);
                cmdStok.Parameters.AddWithValue("@id", detail.IphoneId);
                cmdStok.ExecuteNonQuery();

                return true;
            }
        }
        public List<ComboBoxItem> GetAvailableIphones()
        {
            List<ComboBoxItem> list = new List<ComboBoxItem>();

            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT dftr_ip_ID, seri_hp FROM dftr_ip WHERE stok > 0";
                var cmd = new NpgsqlCommand(query, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new ComboBoxItem
                    {
                        Value = reader.GetInt32(0),
                        Text = reader.GetString(1)
                    });
                }
                conn.Close();
            }

            return list;
        }
    }
}
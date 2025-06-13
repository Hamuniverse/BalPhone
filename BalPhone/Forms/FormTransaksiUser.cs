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

namespace BalPhone.Forms
{
    public partial class FormTransaksiUser : Form
    {
        string connStr = "Host=localhost;Username=postgres;Password=021204;Database=tirent";
        NpgsqlConnection conn;

        public FormTransaksiUser()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connStr);
            LoadIphoneList();
        }

        private void LoadIphoneList()
        {
            try
            {
                conn.Open();
                string query = "SELECT dftr_ip_ID, seri_hp FROM dftr_ip WHERE stok > 0";
                var cmd = new NpgsqlCommand(query, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxIphone.Items.Add(new ComboBoxItem
                    {
                        Value = reader.GetInt32(0),
                        Text = reader.GetString(1)
                    });
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private void btnSewa_Click(object sender, EventArgs e)
        {
            if (comboBoxIphone.SelectedItem == null || !int.TryParse(txtJumlah.Text, out int jumlah)
                || !int.TryParse(txtJumlahHari.Text, out int hari) || !DateTime.TryParse(txtTglKembali.Text, out DateTime tglKembali))
            {
                MessageBox.Show("Isi semua data dengan benar.");
                return;
            }

            var selected = (ComboBoxItem)comboBoxIphone.SelectedItem;

            try
            {
                conn.Open();

                // Ambil harga
                var cmdHarga = new NpgsqlCommand("SELECT harga_sewa, stok FROM dftr_ip WHERE dftr_ip_ID=@id", conn);
                cmdHarga.Parameters.AddWithValue("@id", selected.Value);
                var reader = cmdHarga.ExecuteReader();
                if (!reader.Read())
                {
                    MessageBox.Show("iPhone tidak ditemukan.");
                    conn.Close();
                    return;
                }

                int harga = reader.GetInt32(0);
                int stok = reader.GetInt32(1);
                reader.Close();

                if (jumlah > stok)
                {
                    MessageBox.Show("Jumlah melebihi stok tersedia.");
                    conn.Close();
                    return;
                }

                int total = harga * jumlah * hari;

                var confirm = MessageBox.Show($"Total harga: Rp {total:N0}\nLanjutkan transaksi?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (confirm != DialogResult.Yes)
                {
                    conn.Close();
                    return;
                }

                // Simpan transaksi
                string insertTrans = "INSERT INTO transaksi (waktu_pemesanan, userr_no_telp, userr_email, userr_no_ktp, status_pembayaran) " +
                                     "VALUES (@waktu, @telp, @email, @ktp, 'pending') RETURNING transaksi_ID";
                var cmdTrans = new NpgsqlCommand(insertTrans, conn);
                cmdTrans.Parameters.AddWithValue("@waktu", DateTime.Now);
                cmdTrans.Parameters.AddWithValue("@telp", Session.NoTelp);
                cmdTrans.Parameters.AddWithValue("@email", Session.Email);
                cmdTrans.Parameters.AddWithValue("@ktp", Session.NoKTP);
                int transId = (int)cmdTrans.ExecuteScalar();

                // Simpan detail transaksi
                string insertDtl = "INSERT INTO dtl_trnsksi (jumlah_pesanan, durasi_hari, transaksi_transaksi_ID, dftr_ip_dftr_ip_ID) " +
                                   "VALUES (@jumlah, @hari, @transId, @ipId)";
                var cmdDtl = new NpgsqlCommand(insertDtl, conn);
                cmdDtl.Parameters.AddWithValue("@jumlah", jumlah);
                cmdDtl.Parameters.AddWithValue("@hari", hari);
                cmdDtl.Parameters.AddWithValue("@transId", transId);
                cmdDtl.Parameters.AddWithValue("@ipId", selected.Value);
                cmdDtl.ExecuteNonQuery();

                // Update stok
                var cmdStok = new NpgsqlCommand("UPDATE dftr_ip SET stok = stok - @jumlah WHERE dftr_ip_ID = @ipId", conn);
                cmdStok.Parameters.AddWithValue("@jumlah", jumlah);
                cmdStok.Parameters.AddWithValue("@ipId", selected.Value);
                cmdStok.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Transaksi berhasil!");
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Gagal menyimpan transaksi: " + ex.Message);
            }
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            FormRiwayatTransaksi riwayat = new FormRiwayatTransaksi();
            riwayat.ShowDialog();
        }
    }

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }
        public override string ToString() => Text;
    }
}
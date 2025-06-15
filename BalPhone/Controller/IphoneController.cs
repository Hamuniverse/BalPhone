using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data;
using Npgsql;
using BalPhone.Models;

namespace BalPhone.Controllers
{
    public class IphoneController
    {
        private readonly string connStr = "Host=localhost;Username=postgres;Password=021204;Database=BalPhone";

        public List<Iphone> GetAll()
        {
            var list = new List<Iphone>();
            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT * FROM dftr_ip ORDER BY dftr_ip_id", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Iphone
                    {
                        Id = (int)reader["dftr_ip_id"],
                        Seri = reader["seri_hp"].ToString(),
                        HargaSewa = (int)reader["harga_sewa"],
                        Stok = (int)reader["stok"],
                        Deskripsi = reader["deskripsi"].ToString()
                    });
                }
            }
            return list;
        }

        public void Insert(Iphone ip)
        {
            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("INSERT INTO dftr_ip (seri_hp, harga_sewa, stok, deskripsi) VALUES (@seri, @harga, @stok, @desc)", conn);
                cmd.Parameters.AddWithValue("@seri", ip.Seri);
                cmd.Parameters.AddWithValue("@harga", ip.HargaSewa);
                cmd.Parameters.AddWithValue("@stok", ip.Stok);
                cmd.Parameters.AddWithValue("@desc", ip.Deskripsi);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Iphone ip)
        {
            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("UPDATE dftr_ip SET seri_hp=@seri, harga_sewa=@harga, stok=@stok, deskripsi=@desc WHERE dftr_ip_id=@id", conn);
                cmd.Parameters.AddWithValue("@seri", ip.Seri);
                cmd.Parameters.AddWithValue("@harga", ip.HargaSewa);
                cmd.Parameters.AddWithValue("@stok", ip.Stok);
                cmd.Parameters.AddWithValue("@desc", ip.Deskripsi);
                cmd.Parameters.AddWithValue("@id", ip.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("DELETE FROM dftr_ip WHERE dftr_ip_id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

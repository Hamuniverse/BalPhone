using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using BalPhone.Models;

namespace BalPhone.Controllers
{
    public class UserController
    {
        private readonly string connStr = "Host=localhost;Username=postgres;Password=021204;Database=BalPhone";

        public bool Register(User user)
        {
            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();

                var check = new NpgsqlCommand("SELECT COUNT(*) FROM userr WHERE username = @username OR email = @email", conn);
                check.Parameters.AddWithValue("@username", user.Username);
                check.Parameters.AddWithValue("@email", user.Email);
                long exists = (long)check.ExecuteScalar();
                if (exists > 0)
                    return false;

                var cmd = new NpgsqlCommand("INSERT INTO userr (nama, username, password, email, no_telp, no_ktp, rolee_rolee_ID) VALUES (@nama, @username, @password, @email, @telp, @ktp, @role)", conn);
                cmd.Parameters.AddWithValue("@nama", user.Nama);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@telp", user.NoTelp);
                cmd.Parameters.AddWithValue("@ktp", user.NoKTP);
                cmd.Parameters.AddWithValue("@role", user.RoleId);
                cmd.ExecuteNonQuery();
                return true;
            }
        }


        public User Login(string username, string password)
        {
            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT * FROM userr WHERE username=@username AND password=@password", conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new User
                    {
                        Nama = reader["nama"].ToString(),
                        Username = reader["username"].ToString(),
                        Password = reader["password"].ToString(),
                        Email = reader["email"].ToString(),
                        NoTelp = reader["no_telp"].ToString(),
                        NoKTP = reader["no_ktp"].ToString(),
                        RoleId = Convert.ToInt32(reader["rolee_rolee_ID"])
                    };
                }
                return null;
            }
        }
    }
}

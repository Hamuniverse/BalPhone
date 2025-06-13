using Npgsql;
using BalPhone.Models;
using System;
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
    public partial class FormLogin : Form
    {
        string connStr = "Host=localhost;Username=postgres;Password=021204;Database=tirent";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Username dan password tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT username, email, no_telp, no_ktp, rolee_rolee_ID FROM userr WHERE username = @username AND password = @password";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Simpan data session
                                Session.Username = reader["username"].ToString();
                                Session.Email = reader["email"].ToString();
                                Session.NoTelp = reader["no_telp"].ToString();
                                Session.NoKTP = reader["no_ktp"].ToString();

                                int roleId = Convert.ToInt32(reader["rolee_rolee_ID"]);

                                MessageBox.Show("Login berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();

                                if (roleId == 1) // Admin
                                {
                                    new FormDashboardAdmin().Show();
                                }
                                else // User
                                {
                                    new FormDashboardUser().Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Username atau password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan koneksi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormRegister reg = new FormRegister();
            reg.ShowDialog();
        }
    }
}
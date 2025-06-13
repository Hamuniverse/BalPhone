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
    public partial class FormRegister : Form
    {
        string connStr = "Host=localhost;Username=postgres;Password=021204;Database=tirent";

        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtNama.Text == "" ||
                txtTelp.Text == "" || txtEmail.Text == "" || txtKTP.Text == "")
            {
                MessageBox.Show("Mohon isi semua field!");
                return;
            }

            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string sql = "INSERT INTO userr (nama, no_telp, email, username, password, no_ktp, rolee_rolee_ID) " +
                             "VALUES (@nama, @no_telp, @email, @username, @password, @no_ktp, 2)";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("no_telp", txtTelp.Text);
                    cmd.Parameters.AddWithValue("email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("no_ktp", txtKTP.Text);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registrasi berhasil! Silakan login.");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal registrasi: " + ex.Message);
                    }
                }
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide(); // sembunyikan form register
            new FormLogin().Show(); // tampilkan form login
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtNama.Text == "" ||
                txtTelp.Text == "" || txtEmail.Text == "" || txtKTP.Text == "")
            {
                MessageBox.Show("Mohon isi semua field!");
                return;
            }

            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string sql = "INSERT INTO userr (nama, no_telp, email, username, password, no_ktp, rolee_rolee_ID) " +
                             "VALUES (@nama, @no_telp, @email, @username, @password, @no_ktp, 2)";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("no_telp", txtTelp.Text);
                    cmd.Parameters.AddWithValue("email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("no_ktp", txtKTP.Text);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registrasi berhasil! Silakan login.");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal registrasi: " + ex.Message);
                    }
                }
            }
        }

    }
}
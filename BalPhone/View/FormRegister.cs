using BalPhone.Controllers;
using BalPhone.Models;
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
        private UserController userController = new UserController();

        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLogin().Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTelp.Text) ||
                string.IsNullOrWhiteSpace(txtKTP.Text))
            {
                MessageBox.Show("Semua kolom wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buat object User
            var newUser = new User
            {
                Nama = txtNama.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Email = txtEmail.Text,
                NoTelp = txtTelp.Text,
                NoKTP = txtKTP.Text,
                RoleId = 2  // default user
            };

            // Coba register
            bool success = userController.Register(newUser);
            if (success)
            {
                MessageBox.Show("Registrasi berhasil! Silakan login.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new FormLogin().Show();
            }
            else
            {
                MessageBox.Show("Username atau Email sudah digunakan.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
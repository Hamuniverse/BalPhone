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
using BalPhone.Controllers;

namespace BalPhone.Forms
{
    public partial class FormLogin : Form
    {
        UserController userController = new UserController();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Username dan password tidak boleh kosong.");
                return;
            }

            User user = userController.Login(txtUsername.Text, txtPassword.Text);
            if (user != null)
            {
                Session.Nama = user.Nama;
                Session.Username = user.Username;
                Session.Email = user.Email;
                Session.NoTelp = user.NoTelp;
                Session.NoKTP = user.NoKTP;

                MessageBox.Show("Login berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                if (user.RoleId == 1)
                    new FormDashboardAdmin().Show();
                else
                    new FormDashboardUser().Show();
            }
            else
            {
                MessageBox.Show("Username atau password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormRegister reg = new FormRegister();
            reg.ShowDialog();
        }
    }
}
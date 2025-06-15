using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalPhone.Models
{
    public class User
    {
        public string Nama { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string NoTelp { get; set; }
        public string NoKTP { get; set; }
        public int RoleId { get; set; }
    }
}


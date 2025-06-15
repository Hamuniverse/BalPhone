using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalPhone.Models
{
    public class Transaksi
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string NoTelp { get; set; }
        public string NoKTP { get; set; }
        public DateTime WaktuPemesanan { get; set; }
        public string StatusPembayaran { get; set; }
    }
}
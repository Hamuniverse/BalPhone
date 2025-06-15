using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalPhone.Models
{
    public class DetailTransaksi
    {
        public int TransaksiId { get; set; }
        public int IphoneId { get; set; }
        public int Jumlah { get; set; }
        public int JumlahHari { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_Management_System
{
    public class Billing
    {
        public int IdBilling { get; set; }
        public int JumlahPembayaran { get; set; }
        public string TanggalPembayaran { get; set; }
        public string StatusPembayaran { get; set; }
        public string NamaPasien { get; set; }
    }
}

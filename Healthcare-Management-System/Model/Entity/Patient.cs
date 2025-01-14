using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_Management_System
{
    public class Patient
    {
        public int IdPatient { get; set; }
        public string NamaDepan {get; set;}
        public string NamaBelakang {get; set;}
        public string TanggalLahir { get; set;}
        public string NomorTelepon {get; set;}
        public string Alamat {get; set;}
        public string JenisKelamin {get; set;}
        public string Asuransi { get; set;}
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_Management_System
{
    public class Medical_Record
    {
        public int IdMedicalRecord {  get; set; }
        public string Diagnosis { get; set; }
        public string Perawatan { get; set; }
        public string TanggalRawat { get; set; }
        public string NamaPasien {  get; set; }
        public string Obat { get; set; }
    }
}

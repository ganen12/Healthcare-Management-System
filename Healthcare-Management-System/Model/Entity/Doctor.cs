using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_Management_System
{
    public class Doctor
    {
        public int IdDoctor { get; set; }
        public string NamaDepan { get; set; }
        public string NamaBelakang { get; set; }
        public string Spesialisasi { get; set; }
        public string jadwalArr { get; set; }
        // public List<string> jadwalArr = new List<string>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_Management_System
{
    public class Appointment
    {
        public int IdAppointment { get; set; }
        public string NamaPasien { get; set; }
        public string NamaDokter { get; set; }
        public string TanggalPertemuan { get; set; }
        public string JamPertemuan { get; set; }
        public string Status { get; set; }
    }
}

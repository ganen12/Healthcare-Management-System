using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Healthcare_Management_System.Model.Entity;

namespace Healthcare_Management_System
{
    public static class DataStore
    {
        public static List<Patient> PatientsList = new List<Patient>();
        public static List<Doctor> DoctorsList = new List<Doctor>();
        public static List<Appointment> AppointmentsList = new List<Appointment>();
        public static List<Medical_Record> MedicalRecordsList = new List<Medical_Record>();
        public static List<Billing> BillingsList = new List<Billing>();
        public static List<Users> UsersList = new List<Users>();
    }
}
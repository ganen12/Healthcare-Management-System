using Healthcare_Management_System.Model.Context;
using Healthcare_Management_System.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healthcare_Management_System.Controller
{
    public class AppointmentController
    {
        private AppointmentRepository _repository;

        public List<Appointment> ReadAll()
        {
            List<Appointment> list = new List<Appointment>();

            using (DbContext context = new DbContext())
            {
                _repository = new AppointmentRepository(context);

                list = _repository.ReadAll();
            }

            return list;
        }

        public int Create(Appointment appointment)
        {
            int result = 0;
            
            if (string.IsNullOrEmpty(appointment.NamaPasien))
            {
                MessageBox.Show("Nama pasien harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(appointment.NamaDokter))
            {
                MessageBox.Show("Nama dokter harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(appointment.TanggalPertemuan))
            {
                MessageBox.Show("tanggal harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(appointment.JamPertemuan))
            {
                MessageBox.Show("jam harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(appointment.Status))
            {
                MessageBox.Show("status harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new AppointmentRepository(context);

                result = _repository.Create(appointment);
            }

            if (result > 0)
            {
                MessageBox.Show("Data pertemuan berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data pertemuan gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Update(Appointment appointment)
        {
            int result = 0;

            if (string.IsNullOrEmpty(appointment.NamaPasien))
            {
                MessageBox.Show("Nama pasien harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(appointment.NamaDokter))
            {
                MessageBox.Show("Nama dokter harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(appointment.TanggalPertemuan))
            {
                MessageBox.Show("Tanggal harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(appointment.JamPertemuan))
            {
                MessageBox.Show("Jam harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(appointment.Status))
            {
                MessageBox.Show("status harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new AppointmentRepository(context);

                result = _repository.Update(appointment);
            }

            if (result > 0)
            {
                MessageBox.Show("Data pertemuan berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data pertemuan gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Appointment appointment)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new AppointmentRepository(context);

                result = _repository.Delete(appointment);
            }

            if (result > 0)
            {
                MessageBox.Show("Data pertemuan berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data pertemuan gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
        
        public int DeleteAll()
        {
            int result;

            using (DbContext context = new DbContext())
            {
                _repository = new AppointmentRepository(context);

                result = _repository.DeleteAll();
            }

            if (result > 0)
            {
                MessageBox.Show("Data pertemuan berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data pertemuan gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
        

        public int ResetAppointmentAutoIncrement()
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new AppointmentRepository(context);

                result = _repository.ResetAutoIncrement();
            }

            return result;
        }
    }
}

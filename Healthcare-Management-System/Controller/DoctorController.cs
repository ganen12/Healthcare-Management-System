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
    public class DoctorController
    {
        private DoctorRepository _repository;

        public List<Doctor> ReadAll()
        {
            List<Doctor> list = new List<Doctor>();

            using (DbContext context = new DbContext())
            {
                _repository = new DoctorRepository(context);

                list = _repository.ReadAll();
            }

            return list;
        }

        public int Create(Doctor dokter)
        {
            int result = 0;
            string jadwalDokter = string.Join(",", dokter.jadwalArr);

            if (string.IsNullOrEmpty(dokter.NamaDepan))
            {
                MessageBox.Show("Nama depan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(dokter.NamaBelakang))
            {
                MessageBox.Show("Nama belakang harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(dokter.Spesialisasi))
            {
                MessageBox.Show("Spesialisasi harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new DoctorRepository(context);

                result = _repository.Create(dokter);
            }

            if (result > 0)
            {
                MessageBox.Show("Data dokter berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data dokter gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
        
        public int Update(Doctor doctor)
        {
            int result = 0;

            if (string.IsNullOrEmpty(doctor.NamaDepan))
            {
                MessageBox.Show("Nama depan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(doctor.NamaBelakang))
            {
                MessageBox.Show("Nama belakang harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(doctor.Spesialisasi))
            {
                MessageBox.Show("Spesialisasi harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new DoctorRepository(context);

                result = _repository.Update(doctor);
            }

            if (result > 0)
            {
                MessageBox.Show("Data dokter berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data dokter gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int UpdateJadwalSaja(Doctor doctor)
        {
            int result = 0;

            if (string.IsNullOrEmpty(doctor.jadwalArr))
            {
                MessageBox.Show("Jadwal harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new DoctorRepository(context);

                result = _repository.UpdateJadwalSaja(doctor);
            }

            if (result > 0)
            {
                MessageBox.Show("Data dokter berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data dokter gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Doctor doctor)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new DoctorRepository(context);

                result = _repository.Delete(doctor);
            }

            if (result > 0)
            {
                MessageBox.Show("Data dokter berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data dokter gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int DeleteAll()
        {
            int result;

            using (DbContext context = new DbContext())
            {
                _repository = new DoctorRepository(context);

                result = _repository.DeleteAll();
            }

            if (result > 0)
            {
                MessageBox.Show("Data dokter berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data dokter gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int ResetDoctorAutoIncrement()
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new DoctorRepository(context);

                result = _repository.ResetAutoIncrement();
            }

            return result;
        }
    }
}

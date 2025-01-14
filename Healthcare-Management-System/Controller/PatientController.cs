using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data.SQLite;
using Healthcare_Management_System.Model.Repository;
using Healthcare_Management_System.Model.Context;
using System.Runtime.ConstrainedExecution;

namespace Healthcare_Management_System.Controller
{
    public class PatientController
    {
        private PatientRepository _repository;

        public List<Patient> ReadAll()
        {
            List<Patient> list = new List<Patient>();

            using (DbContext context = new DbContext())
            {
                _repository = new PatientRepository(context);

                list = _repository.ReadAll();
            }

            return list;
        }

        public int Create(Patient patient)
        {
            int result = 0;

            if (string.IsNullOrEmpty(patient.NamaDepan))
            {
                MessageBox.Show("Nama depan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(patient.NamaBelakang))
            {
                MessageBox.Show("Nama belakang harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(patient.TanggalLahir))
            {
                MessageBox.Show("Tanggal lahir harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(patient.JenisKelamin))
            {
                MessageBox.Show("Jenis kelamin harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(patient.Alamat))
            {
                MessageBox.Show("Alamat harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(patient.NomorTelepon))
            {
                MessageBox.Show("Nomor telepon harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(patient.Asuransi))
            {
                MessageBox.Show("Jenis asuransi harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new PatientRepository(context);

                result = _repository.Create(patient);
            }

            if (result > 0)
            {
                MessageBox.Show("Data pasien berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data pasien gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Update(Patient patient)
        {
            int result = 0;

            if (string.IsNullOrEmpty(patient.NamaDepan))
            {
                MessageBox.Show("Nama depan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(patient.NamaBelakang))
            {
                MessageBox.Show("Nama belakang harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(patient.TanggalLahir))
            {
                MessageBox.Show("Tanggal lahir harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(patient.JenisKelamin))
            {
                MessageBox.Show("Jenis kelamin harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(patient.Alamat))
            {
                MessageBox.Show("Alamat harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(patient.NomorTelepon))
            {
                MessageBox.Show("Nomor telepon harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(patient.Asuransi))
            {
                MessageBox.Show("Jenis asuransi harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new PatientRepository(context);

                result = _repository.Update(patient);
            }

            if (result > 0)
            {
                MessageBox.Show("Data pasien berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data pasien gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Patient patient)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new PatientRepository(context);

                result = _repository.Delete(patient);
            }

            if (result > 0)
            {
                MessageBox.Show("Data pasien berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data pasien gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }        

        public int DeleteAll()
        {
            int result;

            using (DbContext context = new DbContext())
            {
                _repository = new PatientRepository(context);

                result = _repository.DeleteAll();
            }

            if (result > 0)
            {
                MessageBox.Show("Data pasien berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data pasien gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int ResetPatientAutoIncrement()
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new PatientRepository(context);

                result = _repository.ResetAutoIncrement();
            }

            return result;
        }
    }
}
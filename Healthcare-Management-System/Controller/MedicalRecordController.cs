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
    public class MedicalRecordController
    {
        private MedicalRecordRepository _repository;

        public List<Medical_Record> ReadAll()
        {
            List<Medical_Record> list = new List<Medical_Record>();

            using (DbContext context = new DbContext())
            {
                _repository = new MedicalRecordRepository(context);

                list = _repository.ReadAll();
            }

            return list;
        }

        public int Create(Medical_Record catatan)
        {
            int result = 0;

            if (string.IsNullOrEmpty(catatan.NamaPasien))
            {
                MessageBox.Show("Nama pasien harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(catatan.TanggalRawat))
            {
                MessageBox.Show("Tanggal harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(catatan.Perawatan))
            {
                MessageBox.Show("Perawatan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(catatan.Diagnosis))
            {
                MessageBox.Show("Diagnosis harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(catatan.Obat))
            {
                MessageBox.Show("Obat harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new MedicalRecordRepository(context);

                result = _repository.Create(catatan);
            }

            if (result > 0)
            {
                MessageBox.Show("Catatan medis berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Catatan medis gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Update(Medical_Record catatan)
        {
            int result = 0;

            if (string.IsNullOrEmpty(catatan.NamaPasien))
            {
                MessageBox.Show("Nama pasien harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(catatan.TanggalRawat))
            {
                MessageBox.Show("Tanggal harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(catatan.Perawatan))
            {
                MessageBox.Show("Perawatan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(catatan.Diagnosis))
            {
                MessageBox.Show("Diagnosis harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(catatan.Obat))
            {
                MessageBox.Show("Obat harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new MedicalRecordRepository(context);

                result = _repository.Update(catatan);
            }

            if (result > 0)
            {
                MessageBox.Show("Catatan medis berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Catatan medis gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Medical_Record catatan)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new MedicalRecordRepository(context);

                result = _repository.Delete(catatan);
            }

            if (result > 0)
            {
                MessageBox.Show("Catatan medis berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Catatan medis gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int DeleteAll()
        {
            int result;

            using (DbContext context = new DbContext())
            {
                _repository = new MedicalRecordRepository(context);

                result = _repository.DeleteAll();
            }

            if (result > 0)
            {
                MessageBox.Show("Catatan medis berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Catatan medis gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }


        public int ResetMedicalRecordAutoIncrement()
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new MedicalRecordRepository(context);

                result = _repository.ResetAutoIncrement();
            }

            return result;
        }
    }
}

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
    public class BillingController
    {
        private BillingRepository _repository;

        public List<Billing> ReadAll()
        {
            List<Billing> list = new List<Billing>();

            using (DbContext context = new DbContext())
            {
                _repository = new BillingRepository(context);

                list = _repository.ReadAll();
            }

            return list;
        }

        public int Create(Billing billing)
        {
            int result = 0;

            if (string.IsNullOrEmpty(billing.NamaPasien))
            {
                MessageBox.Show("Nama pasien harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(billing.JumlahPembayaran.ToString()))
            {
                MessageBox.Show("jumlah harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(billing.TanggalPembayaran))
            {
                MessageBox.Show("tanggal harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(billing.StatusPembayaran))
            {
                MessageBox.Show("status pembayaran harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new BillingRepository(context);

                result = _repository.Create(billing);
            }

            if (result > 0)
            {
                MessageBox.Show("Data pembayaran berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data pembayaran gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Update(Billing billing)
        {
            int result = 0;

            if (string.IsNullOrEmpty(billing.NamaPasien))
            {
                MessageBox.Show("Nama pasien harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(billing.JumlahPembayaran.ToString()))
            {
                MessageBox.Show("jumlah harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(billing.TanggalPembayaran))
            {
                MessageBox.Show("tanggal harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(billing.StatusPembayaran))
            {
                MessageBox.Show("status pembayaran harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new BillingRepository(context);

                result = _repository.Update(billing);
            }

            if (result > 0)
            {
                MessageBox.Show("Data pembayaran berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data pembayaran gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Billing billing)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new BillingRepository(context);

                result = _repository.Delete(billing);
            }

            if (result > 0)
            {
                MessageBox.Show("Data pembayaran berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data pembayaran gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int DeleteAll()
        {
            int result;

            using (DbContext context = new DbContext())
            {
                _repository = new BillingRepository(context);

                result = _repository.DeleteAll();
            }

            if (result > 0)
            {
                MessageBox.Show("Data billing berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data billing gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int ResetBillingAutoIncrement()
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new BillingRepository(context);

                result = _repository.ResetAutoIncrement();
            }

            return result;
        }
    }
}

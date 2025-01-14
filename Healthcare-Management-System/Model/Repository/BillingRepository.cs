using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Healthcare_Management_System.Model.Context;
using System.Windows.Forms;

namespace Healthcare_Management_System.Model.Repository
{
    public class BillingRepository
    {
        private SQLiteConnection _conn;

        public BillingRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public void EnableForeignKey()
        {
            using (var pragmaCmd = new SQLiteCommand("PRAGMA foreign_keys = ON;", _conn))
            {
                pragmaCmd.ExecuteNonQuery();
            }
        }

        public int Create(Billing billing)
        {
            EnableForeignKey();

            int result = 0;

            string sql = @"insert into pembayaran (nama_pasien, jumlah_pembayaran, tanggal_pembayaran, status_pembayaran)
                           values (@nama, @jumlahPembayaran, @tanggalPembayaran, @status)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@jumlahPembayaran", billing.JumlahPembayaran);
                cmd.Parameters.AddWithValue("@tanggalPembayaran", billing.TanggalPembayaran);
                cmd.Parameters.AddWithValue("@status",billing.StatusPembayaran);
                cmd.Parameters.AddWithValue("@nama", billing.NamaPasien);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database tidak terbaca, gagal menambah pembayaran: " + ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Update(Billing billing)
        {
            EnableForeignKey();

            int result = 0;

            string sql = @"update pembayaran set jumlah_pembayaran = @jumlah, tanggal_pembayaran = @tanggal, status_pembayaran = @status, nama_pasien = @nama
                           where id_pembayaran = @id";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@nama", billing.NamaPasien);
                cmd.Parameters.AddWithValue("@jumlah", billing.JumlahPembayaran);
                cmd.Parameters.AddWithValue("@tanggal", billing.TanggalPembayaran);
                cmd.Parameters.AddWithValue("@status", billing.StatusPembayaran);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Delete(Billing billing)
        {
            EnableForeignKey();

            int result = 0;

            string sql = @"delete from pembayaran
                           where id_pembayaran = @id";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@id", billing.IdBilling);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int DeleteAll()
        {
            int result = 0;

            string sql = @"delete from pembayaran";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database tidak terbaca, data tidak bisa dihapus: " + ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }

            return result;
        }

        public List<Billing> ReadAll()
        {
            EnableForeignKey();

            List<Billing> list = new List<Billing>();

            try
            {
                string sql = @"select id_pembayaran, nama_pasien, tanggal_pembayaran, jumlah_pembayaran, status_pembayaran 
                               from pembayaran order by id_pembayaran";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Billing billing = new Billing();

                            billing.IdBilling = int.Parse(dtr["id_pembayaran"].ToString());
                            billing.JumlahPembayaran = int.Parse(dtr["jumlah_pembayaran"].ToString());
                            billing.TanggalPembayaran = dtr["tanggal_pembayaran"].ToString();
                            billing.StatusPembayaran = dtr["status_pembayaran"].ToString();
                            billing.NamaPasien = dtr["nama_pasien"].ToString();

                            list.Add(billing);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return list;
        }

        
        public int ResetAutoIncrement()
        {
            int result = 0;

            try
            {
                string sqlReset = "DELETE FROM sqlite_sequence WHERE name = 'pembayaran'";

                using (SQLiteCommand cmd = new SQLiteCommand(sqlReset, _conn))
                {
                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during auto-increment reset: {ex.Message}");
            }

            return result;
        }
    }
}

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
    public class MedicalRecordRepository
    {
        private SQLiteConnection _conn;

        public MedicalRecordRepository(DbContext context)
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

        public int Create(Medical_Record catatan)
        {
            EnableForeignKey();

            int result = 0;

            string sql = @"insert into catatan_medis (nama_pasien, tanggal, perawatan, diagnosis, obat)
                           values (@nama, @tanggal, @perawatan, @diagnosis, @obat)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@nama", catatan.NamaPasien);
                cmd.Parameters.AddWithValue("@tanggal", catatan.TanggalRawat);
                cmd.Parameters.AddWithValue("@perawatan", catatan.Perawatan);
                cmd.Parameters.AddWithValue("@diagnosis", catatan.Diagnosis);
                cmd.Parameters.AddWithValue("@obat", catatan.Obat);

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

        public int Update(Medical_Record catatan)
        {
            EnableForeignKey();

            int result = 0;

            string sql = @"update catatan_medis set nama_pasien = @nama, tanggal = @tanggal, perawatan = @perawatan, diagnosis = @diagnosis, obat = @obat
                           where id_catatan = @id";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@id", catatan.IdMedicalRecord);
                cmd.Parameters.AddWithValue("@nama", catatan.NamaPasien);
                cmd.Parameters.AddWithValue("@tanggal", catatan.TanggalRawat);
                cmd.Parameters.AddWithValue("@perawatan", catatan.Perawatan);
                cmd.Parameters.AddWithValue("@diagnosis", catatan.Diagnosis);
                cmd.Parameters.AddWithValue("@obat", catatan.Obat);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database tidak terbaca, gagal mmengupdate medical record: " + ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Delete(Medical_Record catatan)
        {
            EnableForeignKey();

            int result = 0;

            string sql = @"delete from catatan_medis
                           where id_catatan = @id";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@id", catatan.IdMedicalRecord);

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

            string sql = @"delete from catatan_medis";

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

        public List<Medical_Record> ReadAll()
        {
            EnableForeignKey();

            List<Medical_Record> list = new List<Medical_Record>();

            try
            {
                string sql = @"select id_catatan, nama_pasien, diagnosis, perawatan, tanggal, obat
                               from catatan_medis order by id_catatan";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Medical_Record catatan = new Medical_Record();

                            catatan.IdMedicalRecord = int.Parse(dtr["id_catatan"].ToString());
                            catatan.NamaPasien = dtr["nama_pasien"].ToString();
                            catatan.Diagnosis = dtr["diagnosis"].ToString();
                            catatan.Perawatan = dtr["perawatan"].ToString();
                            catatan.TanggalRawat = dtr["tanggal"].ToString();
                            catatan.Obat = dtr["obat"].ToString();

                            list.Add(catatan);
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
                string sqlReset = "DELETE FROM sqlite_sequence WHERE name = 'catatan_medis'";

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

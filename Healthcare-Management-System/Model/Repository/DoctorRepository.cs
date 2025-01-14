using Healthcare_Management_System.Model.Context;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healthcare_Management_System.Model.Repository
{
    public class DoctorRepository
    {
        private SQLiteConnection _conn;

        public DoctorRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Doctor doctor)
        {
            int result = 0;

            string sql = @"insert into dokter (nama_depan, nama_belakang, spesialisasi, jadwal)
                           values (@namaDepan, @namaBelakang, @spesialisasi, @jadwal)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@namaDepan", doctor.NamaDepan);
                cmd.Parameters.AddWithValue("@namaBelakang", doctor.NamaBelakang);
                cmd.Parameters.AddWithValue("@spesialisasi", doctor.Spesialisasi);
                cmd.Parameters.AddWithValue("@jadwal", doctor.jadwalArr);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database tidak terbaca, gagal menginput dokter", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }

            return result;
        }

        public List<Doctor> ReadAll()
        {
            List<Doctor> listFromDb = new List<Doctor>();

            try
            {
                string sql = @"select id_dokter, nama_depan, nama_belakang, spesialisasi, jadwal
                               from dokter order by id_dokter";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Doctor doctor = new Doctor();

                            doctor.IdDoctor = int.Parse(dtr["id_dokter"].ToString());
                            doctor.NamaDepan = dtr["nama_depan"].ToString();
                            doctor.NamaBelakang = dtr["nama_belakang"].ToString();
                            doctor.Spesialisasi = dtr["spesialisasi"].ToString();
                            doctor.jadwalArr = dtr["jadwal"].ToString();

                            listFromDb.Add(doctor);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database tidak terbaca", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return listFromDb;
        }

        
        public int Update(Doctor doctor)
        {
            int result = 0;

            string sql = @"update dokter set nama_depan = @namaDepan, nama_belakang = @namaBelakang, spesialisasi = @spesialisasi, jadwal = @jadwal
                           where id_dokter = @idDokter";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@idDokter", doctor.IdDoctor);
                cmd.Parameters.AddWithValue("@namaDepan", doctor.NamaDepan);
                cmd.Parameters.AddWithValue("@namaBelakang", doctor.NamaBelakang);
                cmd.Parameters.AddWithValue("@spesialisasi", doctor.Spesialisasi);
                cmd.Parameters.AddWithValue("@jadwal", doctor.jadwalArr);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database tidak terbaca, gagal mengupdate dokter", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }

            return result;
        }
        
        public int UpdateJadwalSaja(Doctor doctor)
        {
            int result = 0;

            string sql = @"update dokter set jadwal = @jadwal
                           where id_dokter = @idDokter";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@idDokter", doctor.IdDoctor);
                cmd.Parameters.AddWithValue("@jadwal", doctor.jadwalArr);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database tidak terbaca, gagal mengupdate dokter", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Delete(Doctor doctor)
        {
            int result = 0;

            string sql = @"delete from dokter
                           where id_dokter = @idDokter";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@idDokter", doctor.IdDoctor);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database tidak terbaca", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int DeleteAll()
        {
            int result = 0;

            string sql = @"delete from dokter";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database tidak terbaca, data tidak bisa dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int ResetAutoIncrement()
        {
            int result = 0;

            try
            {
                string sqlReset = "DELETE FROM sqlite_sequence WHERE name = 'dokter'";

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

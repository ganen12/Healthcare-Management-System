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
    public class PatientRepository
    {
        private SQLiteConnection _conn;

        public PatientRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Patient patient)
        {
            int result = 0;

            string sql = @"insert into pasien (nama_depan, nama_belakang, tanggal_lahir, jenis_kelamin, alamat, no_telepon, asuransi)
                           values (@namaDepan, @namaBelakang, @tanggalLahir, @jenisKelamin, @alamat, @noTelpon, @asuransi)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@namaDepan", patient.NamaDepan);
                cmd.Parameters.AddWithValue("@namaBelakang", patient.NamaBelakang);
                cmd.Parameters.AddWithValue("@tanggalLahir", patient.TanggalLahir);
                cmd.Parameters.AddWithValue("@jenisKelamin", patient.JenisKelamin);
                cmd.Parameters.AddWithValue("@alamat", patient.Alamat);
                cmd.Parameters.AddWithValue("@noTelpon", patient.NomorTelepon);
                cmd.Parameters.AddWithValue("@asuransi", patient.Asuransi);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Update(Patient patient)
        {
            int result = 0;

            string sql = @"update pasien set nama_depan = @namaDepan, nama_belakang = @namaBelakang, tanggal_lahir = @tanggalLahir,
                           jenis_kelamin = @jenisKelamin, alamat = @alamat, no_telepon = @noTelpon, asuransi = @asuransi
                           where id_pasien = @idPasien";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@idPasien", patient.IdPatient);
                cmd.Parameters.AddWithValue("@namaDepan", patient.NamaDepan);
                cmd.Parameters.AddWithValue("@namaBelakang", patient.NamaBelakang);
                cmd.Parameters.AddWithValue("@tanggalLahir", patient.TanggalLahir);
                cmd.Parameters.AddWithValue("@jenisKelamin", patient.JenisKelamin);
                cmd.Parameters.AddWithValue("@alamat", patient.Alamat);
                cmd.Parameters.AddWithValue("@noTelpon", patient.NomorTelepon);
                cmd.Parameters.AddWithValue("@asuransi", patient.Asuransi);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database tidak terbaca, gagal mengupdate pasien", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Delete(Patient patient)
        {
            int result = 0;

            string sql = @"delete from pasien
                           where id_pasien = @idPatient";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@idPatient", patient.IdPatient);

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

            string sql = @"delete from pasien";

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

        public List<Patient> ReadAll()
        {
            List<Patient> listFromDb = new List<Patient>();

            try
            {
                string sql = @"select id_pasien, nama_depan, nama_belakang, tanggal_lahir, no_telepon, alamat, jenis_kelamin, asuransi
                               from pasien order by id_pasien";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Patient patient = new Patient();

                            patient.IdPatient = int.Parse(dtr["id_pasien"].ToString());
                            patient.NamaDepan = dtr["nama_depan"].ToString();
                            patient.NamaBelakang = dtr["nama_belakang"].ToString();
                            patient.TanggalLahir = dtr["tanggal_lahir"].ToString();
                            patient.NomorTelepon = dtr["no_telepon"].ToString();
                            patient.Alamat = dtr["alamat"].ToString();
                            patient.JenisKelamin = dtr["jenis_kelamin"].ToString();
                            patient.Asuransi = dtr["asuransi"].ToString();

                            listFromDb.Add(patient);
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

        public int ResetAutoIncrement()
        {
            int result = 0;

            try
            {
                string sqlReset = "DELETE FROM sqlite_sequence WHERE name = 'pasien'";

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
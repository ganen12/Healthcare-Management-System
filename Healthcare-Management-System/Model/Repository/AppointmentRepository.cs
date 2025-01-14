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
    public class AppointmentRepository
    {
        private SQLiteConnection _conn;

        public AppointmentRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Appointment appointment)
        {
            int result = 0;

            string sql = @"insert into pertemuan (nama_pasien, nama_dokter, tanggal_pertemuan, jam_pertemuan, status)
                           values (@namaPasien, @namaDokter, @tanggalPertemuan, @jamPertemuan, @status)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@namaPasien", appointment.NamaPasien);
                cmd.Parameters.AddWithValue("@namaDokter", appointment.NamaDokter);
                cmd.Parameters.AddWithValue("@tanggalPertemuan", appointment.TanggalPertemuan);
                cmd.Parameters.AddWithValue("@jamPertemuan", appointment.JamPertemuan);
                cmd.Parameters.AddWithValue("@status", appointment.Status);

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

        public int Update(Appointment appointment)
        {
            int result = 0;

            string sql = @"update pertemuan set nama_pasien = @namaPasien, nama_dokter = @namaDokter, tanggal_pertemuan = @tanggalPertemuan, status = @status, jam_pertemuan = @jamPertemuan 
                           where id_pertemuan = @idPertemuan";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@idPertemuan", appointment.IdAppointment);
                cmd.Parameters.AddWithValue("@namaPasien", appointment.NamaPasien);
                cmd.Parameters.AddWithValue("@namaDokter", appointment.NamaDokter);
                cmd.Parameters.AddWithValue("@tanggalPertemuan", appointment.TanggalPertemuan);
                cmd.Parameters.AddWithValue("@jamPertemuan", appointment.JamPertemuan);
                cmd.Parameters.AddWithValue("@status", appointment.Status);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database tidak terbaca, gagal mengupdate pertemuan: " + ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Delete(Appointment appointment)
        {
            int result = 0;

            string sql = @"delete from pertemuan
                           where id_pertemuan = @idPertemuan";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@idPertemuan", appointment.IdAppointment);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database tidak terbaca: " + ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int DeleteAll()
        {
            int result = 0;

            string sql = @"delete from pertemuan";

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

        public List<Appointment> ReadAll()
        {
            List<Appointment> listFromDb = new List<Appointment>();

            try
            {
                string sql = @"select id_pertemuan, nama_pasien, nama_dokter, tanggal_pertemuan, status, jam_pertemuan 
                               from pertemuan order by id_pertemuan";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Appointment appointment = new Appointment();

                            appointment.IdAppointment = int.Parse(dtr["id_pertemuan"].ToString());
                            appointment.NamaPasien = dtr["nama_pasien"].ToString();
                            appointment.NamaDokter = dtr["nama_dokter"].ToString();
                            appointment.TanggalPertemuan = dtr["tanggal_pertemuan"].ToString();
                            appointment.Status = dtr["status"].ToString();
                            appointment.JamPertemuan = dtr["jam_pertemuan"].ToString();

                            listFromDb.Add(appointment);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database tidak terbaca, gagal mengakses data (read): " + ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }
            return listFromDb;
        }

        public List<Appointment> ReadByNama(string nama)
        {
            List<Appointment> list = new List<Appointment>();

            try
            {
                string sql = @"select nama_pasien, nama_dokter, tanggal_pertemuan, status 
                               from pertemuan 
                               where nama_pasien like @namaPasien
                               order by id_pertemuan";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@namaPasien", string.Format("%{0}%", nama));

                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Appointment appointment = new Appointment();
                            appointment.NamaPasien = dtr["nama_pasien"].ToString();
                            appointment.NamaDokter = dtr["nama_dokter"].ToString();
                            appointment.TanggalPertemuan = dtr["tanggal_pertemuan"].ToString();
                            appointment.Status = dtr["status"].ToString();

                            list.Add(appointment);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNama error: {0}", ex.Message);
            }

            return list;
        }

        public int ResetAutoIncrement()
        {
            int result = 0;

            try
            {
                string sqlReset = "DELETE FROM sqlite_sequence WHERE name = 'pertemuan'";

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

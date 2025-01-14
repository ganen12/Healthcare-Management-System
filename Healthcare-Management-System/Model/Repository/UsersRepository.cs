using Healthcare_Management_System.Model.Context;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Healthcare_Management_System.Model.Entity;

namespace Healthcare_Management_System.Model.Repository
{
    public class UsersRepository
    {
        private SQLiteConnection _conn;

        public UsersRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Users user)
        {
            int result = 0;

            string sql = @"insert into users (username, password)
                           values (@nama, @pw)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@nama", user.Username);
                cmd.Parameters.AddWithValue("@pw", user.Password);

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

        public List<Users> ReadAll()
        {
            List<Users> listFromDb = new List<Users>();

            try
            {
                string sql = @"select username, password
                               from users order by id_user";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Users user = new Users();

                            
                            user.Username = dtr["username"].ToString();
                            user.Password = dtr["password"].ToString();

                            listFromDb.Add(user);
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
    }
}

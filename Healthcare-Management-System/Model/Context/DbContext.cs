using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;

namespace Healthcare_Management_System.Model.Context
{
    public class DbContext : IDisposable
    {
        private SQLiteConnection _conn;

        public SQLiteConnection Conn
        {
            get { return _conn ?? (_conn = GetOpenConnection()); }
        }
        
        private SQLiteConnection GetOpenConnection()
        {
            SQLiteConnection conn = null; 

            try 
            {
                string dbPath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "Database", "HealthCare.db");
                string dbName = $@"{dbPath}";

                string connectionString = string.Format("Data Source={0};FailIfMissing=True", dbName);

                conn = new SQLiteConnection(connectionString); 
                conn.Open();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("Open Connection Error: {0}", ex.Message);
            }

            return conn;
        }

        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed) _conn.Close();
                }
                finally
                {
                    _conn.Dispose();
                }
            }

            GC.SuppressFinalize(this);
        }
        public bool TestConnection()
        {
            if (Conn != null)
            {
                try
                {
                    if (Conn.State == ConnectionState.Open)
                    {
                        string sql = "SELECT COUNT(*) FROM sqlite_master;";

                        using (SQLiteCommand cmd = new SQLiteCommand(sql, Conn))
                        {
                            object result = cmd.ExecuteScalar();

                            if (result != null)
                            {
                                return true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Connection test error: {0}", ex.Message);
                }
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healthcare_Management_System.Model.Context
{
    public static class DbConnectionTests
    {
        public static void TestDbContext()
        {
            // Create an instance of DbContext
            using (DbContext context = new DbContext())
            {
                if (context.TestConnection())
                {
                    try
                    {
                        string sql = "SELECT COUNT(*) FROM sqlite_master;";

                        using (SQLiteCommand cmd = new SQLiteCommand(sql, context.Conn))
                        {
                            // Execute the query and get the result
                            int count = Convert.ToInt32(cmd.ExecuteScalar());

                            // Display the output of the query
                            MessageBox.Show($"Connection successful! Database has {count} tables/views.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error executing query: " + ex.Message);
                    }
                }
                else
                {
                    // Connection failed
                    MessageBox.Show("Connection failed.");
                }
            }
        }
    }
}

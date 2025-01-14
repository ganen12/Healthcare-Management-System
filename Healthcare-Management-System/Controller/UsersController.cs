using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Healthcare_Management_System.Model.Repository;
using Healthcare_Management_System.Model.Context;
using System.Windows.Forms;
using Healthcare_Management_System.Model.Entity;

namespace Healthcare_Management_System.Controller
{
    public class UsersController
    {
        private UsersRepository _repository;

        public List<Users> ReadAll()
        {
            List<Users> list = new List<Users>();

            using (DbContext context = new DbContext())
            {
                _repository = new UsersRepository(context);

                list = _repository.ReadAll();
            }

            return list;
        }

        public int Create(Users users)
        {
            int result = 0;

            if (string.IsNullOrEmpty(users.Username))
            {
                MessageBox.Show("Username harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(users.Password))
            {
                MessageBox.Show("Password harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new UsersRepository(context);

                result = _repository.Create(users);
            }

            if (result > 0)
            {
                MessageBox.Show("Data user berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data user gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
    }
}

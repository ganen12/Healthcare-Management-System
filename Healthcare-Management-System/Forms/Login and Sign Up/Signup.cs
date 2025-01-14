using Healthcare_Management_System.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Healthcare_Management_System.Model.Entity;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Healthcare_Management_System.Forms.Login_and_Sign_Up
{
    public partial class Signup : Form
    {
        private UsersController UsersController;
        public Signup()
        {
            InitializeComponent();
            UsersController = new UsersController();
            passwordBox.PasswordChar = '*';
            confirmPasswordBox.PasswordChar = '*';
            this.MaximizeBox = false;
        }

        private void passwordBox_Validating(object sender, CancelEventArgs e)
        {
            string password = passwordBox.Text;

            if (password.Length < 4)
            {
                errorProvider1.SetError(passwordBox, "Password must be at least 4 characters long.");
                MessageBox.Show("Password harus memiliki 4 karakter atau lebih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(passwordBox, ""); 
            }
        }

        private int PasswordValitadion()
        {
            string password = passwordBox.Text;

            if (password.Length < 4)
            {
                MessageBox.Show("Password harus memiliki 4 karakter atau lebih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            if (!Regex.IsMatch(password, @"[A-Z]"))
            {
                MessageBox.Show("Password harus mengandung huruf kapital!", "Validasi Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            if (!Regex.IsMatch(password, @"[a-z]"))
            {
                MessageBox.Show("Password harus mengandung huruf kecil!", "Validasi Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            if (!Regex.IsMatch(password, @"[0-9]"))
            {
                MessageBox.Show("Password harus mengandung angka!", "Validasi Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            return 1;
        }

        private int ConfirmPasswordMatch()
        {
            string password = passwordBox.Text.ToString();
            string confirmPassword = confirmPasswordBox.Text.ToString();

            if (password != confirmPassword)
            {
                MessageBox.Show("Password dan konfirmasi password tidak sama", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            if (string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Mohon isi konfirmasi password", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            return 1;
        }

        private void CreateAccount()
        {
            // Validasi apakah semua input sudah diisi
            if (string.IsNullOrWhiteSpace(usernameBox.Text) ||
                string.IsNullOrWhiteSpace(passwordBox.Text))
            {
                MessageBox.Show("Tidak ada data yang diinputkan. Mohon lengkapi semua data.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int result = 0;
            Users user = new Users();
            user.Username = usernameBox.Text;
            user.Password = passwordBox.Text;

            string confirmPassword = confirmPasswordBox.Text.ToString();

            result = UsersController.Create(user);
            if (result > 0)
            {
                NavigateToLogin();
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (PasswordValitadion() == 1 && ConfirmPasswordMatch() == 1)
            {
                CreateAccount();
            }
            else
            {
                return;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
                NavigateToLogin();
        }

        private void NavigateToLogin()
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();

            Application.Exit();
        }

    }
}
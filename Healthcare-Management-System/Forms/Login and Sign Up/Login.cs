using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Healthcare_Management_System.Controller;
using Healthcare_Management_System.Model.Entity;
using System.Security.Authentication;

namespace Healthcare_Management_System.Forms.Login_and_Sign_Up
{
    public partial class Login : Form
    {
        private UsersController UsersController;
        public Login()
        {
            InitializeComponent();
            UsersController = new UsersController();   
            
            DataStore.UsersList = UsersController.ReadAll();
            passwordBox.PasswordChar = '*';
        }

        private void Authentication()
        {
            Users user = new Users();
            user.Username = usernameBox.Text.ToString();
            user.Password = passwordBox.Text.ToString();

            bool userFound = false;

            for (int i = 0; i < DataStore.UsersList.Count(); i++)
            {
                if (user.Username == DataStore.UsersList[i].Username && user.Password == DataStore.UsersList[i].Password)
                {
                    MessageBox.Show("Berhasil login", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userFound = true;

                    Form1 form1 = new Form1();
                    this.Hide();
                    form1.ShowDialog();

                    Application.Exit();
                    break;
                }
            }

            if (userFound == false) {
                MessageBox.Show("Username atau Password salah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            this.Hide();
            signup.ShowDialog();

            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authentication();
        }
    }
}

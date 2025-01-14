using Healthcare_Management_System.Forms.Login_and_Sign_Up;
using Healthcare_Management_System.Model.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healthcare_Management_System
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            //LoadForm(new Pasien());
            //pageTitle.Text = "Pasien";
            InitializeComponent();
            // InisialiasasiListView();
            // DbConnectionTests.TestDbContext();
        }
        
        public void LoadForm(object Form)
        {
            if (this.defaultPanel.Controls.Count > 0)
            {
                this.defaultPanel.Controls.Clear();
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.defaultPanel.Controls.Add(f);
            this.defaultPanel.Tag = f;
            f.Show();
        }
        
        private void patient_btn_update_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadForm(new Pasien());
            pageTitle.Text = "Pasien";
            button1.BackColor = Color.Wheat;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadForm(new dokterPage());
            pageTitle.Text = "Dokter";
            button1.BackColor = Color.White;
            button2.BackColor = Color.Wheat;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadForm(new pertemuanPage());
            pageTitle.Text = "Pertemuan";
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.Wheat;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadForm(new Catatan_Medis());
            pageTitle.Text = "Catatan Medis";
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.Wheat;
            button5.BackColor = Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadForm(new pembayaranPage());
            pageTitle.Text = "Pembayaran";
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.Wheat;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadForm(new Pasien());
            pageTitle.Text = "Pasien";
            button1.BackColor = Color.Wheat;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apa Anda yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Login login = new Login();
                this.Hide();
                login.ShowDialog();

                Application.Exit();
            }
        }
    }
}

/* button logout
 if (MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }
 */
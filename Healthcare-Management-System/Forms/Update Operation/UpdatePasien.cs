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
using Healthcare_Management_System.Forms;

namespace Healthcare_Management_System.Forms
{
    public partial class UpdatePasien : Form
    {
        public Patient patient;
        private PatientController PatientController;
        public UpdatePasien()
        {
            InitializeComponent();
        }

        public UpdatePasien(Patient pasien, PatientController controller) : this()
        {
            this.patient = pasien;
            this.PatientController = controller;
            ShowCurrentPatientData();
        }

        private void ShowCurrentPatientData()
        {
            
            namaDepanTxt.Text = patient.NamaDepan.ToString();
            namaBelakangTxt.Text = patient.NamaBelakang.ToString();
            noTeleponTxt.Text = patient.NomorTelepon.ToString();
            alamatTxt.Text = patient.Alamat.ToString();
            /*
            DateTime dateTime = DateTime.Parse(patient.TanggalLahir);
            dateTimePicker1.Value = dateTime;

            int indexKelamin = patient_comboBox_jenisKelamin.Items.IndexOf(patient.JenisKelamin);
            if (indexKelamin != -1) // Make sure the item exists
            {
                patient_comboBox_jenisKelamin.SelectedIndex = indexKelamin;
            }

            int indexAsuransi = asuransiBox.Items.IndexOf(patient.Asuransi);
            if (indexAsuransi != -1) // Make sure the item exists
            {
                patient_comboBox_jenisKelamin.SelectedIndex = indexAsuransi;
            }
            */
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void patient_btn_update_Click(object sender, EventArgs e)
        {
            patient.NamaDepan = namaDepanTxt.Text.ToString();
            patient.NamaBelakang = namaBelakangTxt.Text.ToString();
            patient.NomorTelepon = noTeleponTxt.Text.ToString();
            patient.Alamat = alamatTxt.Text.ToString();
            patient.TanggalLahir = dateTimePicker1.Value.ToShortDateString();
            patient.JenisKelamin = patient_comboBox_jenisKelamin.SelectedItem.ToString();
            patient.Asuransi = asuransiBox.SelectedItem.ToString();

            int result = 0;
            result = PatientController.Update(patient);

            if (result > 0)
            {
                MessageBox.Show("Data pasien berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
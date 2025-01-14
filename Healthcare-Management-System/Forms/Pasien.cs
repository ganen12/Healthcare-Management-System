using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Healthcare_Management_System.Controller;
using Healthcare_Management_System.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Healthcare_Management_System
{
    public partial class Pasien : Form
    {
        private PatientController PatientController;

        public Pasien()
        {
            InitializeComponent();

            PatientController = new PatientController();
            InisialiasasiListView();
            ShowData();
        }

        private void InisialiasasiListView()
        {
            lvwPatient.View = View.Details;
            lvwPatient.FullRowSelect = true;
            lvwPatient.GridLines = true;
            lvwPatient.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwPatient.Columns.Add("Nama", 200, HorizontalAlignment.Left);
            lvwPatient.Columns.Add("Tanggal Lahir", 120, HorizontalAlignment.Left);
            lvwPatient.Columns.Add("No Telepon", 100, HorizontalAlignment.Left);
            lvwPatient.Columns.Add("Alamat", 120, HorizontalAlignment.Left);
            lvwPatient.Columns.Add("Jenis Kelamin", 120, HorizontalAlignment.Left);
            lvwPatient.Columns.Add("Asuransi", 170, HorizontalAlignment.Center);
        }

        private void ShowData()
        {
            lvwPatient.Items.Clear();

            DataStore.PatientsList = PatientController.ReadAll();

            foreach (var pasien in DataStore.PatientsList)
            {
                var item = new ListViewItem(pasien.IdPatient.ToString());

                item.SubItems.Add(pasien.NamaDepan.ToString() + " " + pasien.NamaBelakang.ToString());
                item.SubItems.Add(pasien.TanggalLahir.ToString());
                item.SubItems.Add("0" + pasien.NomorTelepon.ToString());
                item.SubItems.Add(pasien.Alamat.ToString());
                item.SubItems.Add(pasien.JenisKelamin.ToString());
                item.SubItems.Add(pasien.Asuransi.ToString());

                lvwPatient.Items.Add(item);
            }
        }

        private void ResetForm()
        {
            namaDepanTxt.Clear();
            namaBelakangTxt.Clear();
            noTeleponTxt.Clear();
            alamatTxt.Clear();
            patient_comboBox_jenisKelamin.SelectedItem = null;
        }

        private void AddPatient()
        {
            if (string.IsNullOrWhiteSpace(namaDepanTxt.Text) || 
                string.IsNullOrWhiteSpace(namaBelakangTxt.Text) || 
                string.IsNullOrWhiteSpace(noTeleponTxt.Text) || 
                string.IsNullOrWhiteSpace(alamatTxt.Text) || 
                patient_comboBox_jenisKelamin.SelectedItem == null) 
            {
                MessageBox.Show("Tidak ada data yang diinputkan. Mohon lengkapi semua data.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int result = 0;

            Patient pasien = new Patient();
            pasien.NamaDepan = namaDepanTxt.Text;
            pasien.NamaBelakang = namaBelakangTxt.Text;
            pasien.TanggalLahir = dateTimePicker1.Value.ToShortDateString();
            pasien.NomorTelepon = noTeleponTxt.Text;
            pasien.Alamat = alamatTxt.Text;
            pasien.JenisKelamin = patient_comboBox_jenisKelamin.SelectedItem.ToString();
            pasien.Asuransi = asuransiBox.SelectedItem.ToString();

            result = PatientController.Create(pasien);
            if (result > 0 )
            {
                ResetForm();
            }
        }

        private void btn_add_patient_Click(object sender, EventArgs e)
        {
            AddPatient();
        }

        private void patient_btn_reset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private bool NumericOnly(KeyPressEventArgs e)
        {
            var strValid = "0123456789";

            if (!(e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                if (strValid.IndexOf(e.KeyChar) < 0)
                {
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = NumericOnly(e);
        }

        private void patient_btn_show_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void patient_btn_delete_Click(object sender, EventArgs e)
        {
            if (lvwPatient.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah pasien ini ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    Patient pasien = DataStore.PatientsList[lvwPatient.SelectedIndices[0]];

                    var result = PatientController.Delete(pasien);
                    if (result > 0) ShowData();
                }
            }
            else 
            {
                MessageBox.Show("Tidak ada data pasien yang dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void patient_btn_deleteAll_Click(object sender, EventArgs e)
        {
            var konfirmasi = MessageBox.Show("Apakah semua data catatan medis ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (konfirmasi == DialogResult.Yes)
            {
                lvwPatient.Items.Clear();
                PatientController.DeleteAll();
                PatientController.ResetPatientAutoIncrement();
                ShowData();
            }
        }

        private void cariPasien_TextChanged(object sender, EventArgs e)
        {
            UpdateListView(cariPasien.Text);
        }

        private void UpdateListView(string searchText)
        {
            lvwPatient.Items.Clear();
            if (string.IsNullOrEmpty(searchText))
            {
                ShowData();
                return;
            }

            List<Patient> searchedPatients = new List<Patient>();
            searchedPatients = PatientController.ReadAll();

            foreach (var pasien in searchedPatients)
            {
                string namaLengkap = pasien.NamaDepan + " " + pasien.NamaBelakang;

                if (namaLengkap.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    var item = new ListViewItem(pasien.IdPatient.ToString());

                    item.SubItems.Add(pasien.NamaDepan.ToString() + " " + pasien.NamaBelakang.ToString());
                    item.SubItems.Add(pasien.TanggalLahir.ToString());
                    item.SubItems.Add("0" + pasien.NomorTelepon.ToString());
                    item.SubItems.Add(pasien.Alamat.ToString());
                    item.SubItems.Add(pasien.JenisKelamin.ToString());
                    item.SubItems.Add(pasien.Asuransi.ToString());

                    lvwPatient.Items.Add(item);
                }
            }
        }

        private void patient_btn_update_Click(object sender, EventArgs e)
        {
            if (lvwPatient.SelectedItems.Count > 0)
            {
                var index = lvwPatient.SelectedIndices[0];
                Patient selectedPatient = DataStore.PatientsList[index];

                UpdatePasien updatePasienForm = new UpdatePasien(selectedPatient, PatientController);
                updatePasienForm.ShowDialog();

                ShowData();
            }
            else 
            {
                MessageBox.Show("Tidak ada data pasien yang dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

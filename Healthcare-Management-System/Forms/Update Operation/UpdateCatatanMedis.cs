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

namespace Healthcare_Management_System.Forms.Update_Operation
{
    public partial class UpdateCatatanMedis : Form
    {
        private Medical_Record medical;
        private MedicalRecordController MedicalRecordController;
        public UpdateCatatanMedis()
        {
            InitializeComponent();
        }
        public UpdateCatatanMedis(Medical_Record medical, MedicalRecordController controller) : this()
        {
            this.medical = medical;
            this.MedicalRecordController = controller;
            InisialisasiListViewPatient();
            ShowCurrentMedicalRecordData();

        }
        private void InisialisasiListViewPatient()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Nama Pasien", -2, HorizontalAlignment.Left);

            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            addPatientCollection();
        }
        private void ShowCurrentMedicalRecordData()
        {
            namaPasien.Text = medical.NamaPasien.ToString();

            pertemuanBox.Items.Insert(0, "-- Choose Appointment --");
            pertemuanBox.SelectedIndex = 0;

            diagnosisBox.Text = medical.Diagnosis.ToString();
            perawatanBox.Text = medical.Perawatan.ToString();
            obatBox.Text = medical.Obat.ToString();

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string selectedName = listView1.SelectedItems[0].Text;
                namaPasien.Text = selectedName;

                addAppointmentCollection(selectedName);
            }
        }
        private void addAppointmentCollection(string namaPasien)
        {
            pertemuanBox.Items.Clear(); // Clear existing items

            if (DataStore.AppointmentsList.Count() <= 0)
            {
                infoLabel.Text = "Tidak ada data pertemuan yang ditemukan";
                return;
            }
            bool foundAppointment = false;
            for (int i = 0; i < DataStore.AppointmentsList.Count(); i++)
            {
                // Check if the NamaPasien matches the selected patient
                if (DataStore.AppointmentsList[i].NamaPasien == namaPasien)
                {
                    pertemuanBox.Items.Add("Tanggal " + DataStore.AppointmentsList[i].TanggalPertemuan.ToString() + " - " + DataStore.AppointmentsList[i].JamPertemuan.ToString());
                    foundAppointment = true;
                }
            }

            if (!foundAppointment)
            {
                infoLabel.Text = "Data pertemuan untuk pasien ini tidak ditemukan";
            }

        }
        private void namaPasien_TextChanged(object sender, EventArgs e)
        {
            UpdateListView(namaPasien.Text);
            addAppointmentCollection(namaPasien.Text);
        }
        private void UpdateListView(string searchText)
        {
            // Kosongkan ListView terlebih dahulu
            listView1.Items.Clear();

            // Filter daftar pasien berdasarkan searchText
            foreach (var pasien in DataStore.PatientsList)
            {
                string namaLengkap = pasien.NamaDepan + " " + pasien.NamaBelakang;

                // Cek apakah nama sesuai dengan teks pencarian (case insensitive)
                if (namaLengkap.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    ListViewItem item = new ListViewItem(namaLengkap);
                    listView1.Items.Add(item);
                }
            }
        }

        private void addPatientCollection()
        {
            if (DataStore.PatientsList.Count() <= 0)
            {
                return;
            }
            UpdateListView("");
        }
        private void patient_btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(namaPasien.Text) || string.IsNullOrWhiteSpace(diagnosisBox.Text) || string.IsNullOrWhiteSpace(obatBox.Text) || string.IsNullOrWhiteSpace(perawatanBox.Text) ||
                pertemuanBox.SelectedItem == null)
            {
                MessageBox.Show("Tidak ada data yang diinputkan. Mohon lengkapi semua data.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            medical.NamaPasien = namaPasien.Text;
            medical.Diagnosis = diagnosisBox.Text;
            medical.Perawatan = perawatanBox.Text;
            medical.TanggalRawat = pertemuanBox.SelectedItem.ToString().Substring(8);
            medical.Obat = obatBox.Text;

            int result = 0;
            result = MedicalRecordController.Update(medical);

            if (result > 0)
            {
                MessageBox.Show("Data catatan medis berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}

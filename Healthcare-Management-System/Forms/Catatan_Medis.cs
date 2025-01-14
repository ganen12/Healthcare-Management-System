using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Healthcare_Management_System.Controller;
using Healthcare_Management_System.Forms.Update_Operation;

namespace Healthcare_Management_System
{
    public partial class Catatan_Medis : Form
    {
        private MedicalRecordController MedicalRecordController;
        private AppointmentController AppointmentController;
        private PatientController PatientController;

        public Catatan_Medis()
        {
            InitializeComponent();
            infoLabel.Text = "";
            MedicalRecordController = new MedicalRecordController();
            AppointmentController = new AppointmentController();
            PatientController = new PatientController();

            DataStore.AppointmentsList = AppointmentController.ReadAll();
            DataStore.PatientsList = PatientController.ReadAll();

            InisialisasiListViewPatient();
            InisialisasiListView();
            ShowData();
        }
        private void InisialisasiListViewPatient()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Nama Pasien", -2, HorizontalAlignment.Left);

            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            addPatientCollection();
        }
        private void addPatientCollection()
        {
            if (DataStore.PatientsList.Count() <= 0)
            {
                return;
            }
            UpdateListView("");
        }
        private void InisialisasiListView()
        {
            lvwCatatan.View = View.Details;
            lvwCatatan.FullRowSelect = true;
            lvwCatatan.GridLines = true;
            lvwCatatan.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwCatatan.Columns.Add("Nama Pasien", 200, HorizontalAlignment.Left);
            lvwCatatan.Columns.Add("Diagnosis", 150, HorizontalAlignment.Left);
            lvwCatatan.Columns.Add("Perawatan", 150, HorizontalAlignment.Left);
            lvwCatatan.Columns.Add("Tanggal", 170, HorizontalAlignment.Left);
            lvwCatatan.Columns.Add("Obat", 120, HorizontalAlignment.Left);
        }

        private void ResetForm()
        {
            namaPasien.Clear();
            diagnosisBox.Clear();
            perawatanBox.Clear();
            pertemuanBox.SelectedItem = null;
        }

        private void AddCatatanMedis()
        {
            int result = 0;

            if (string.IsNullOrWhiteSpace(namaPasien.Text) ||
                string.IsNullOrWhiteSpace(diagnosisBox.Text) ||
                string.IsNullOrWhiteSpace(perawatanBox.Text) || string.IsNullOrWhiteSpace(obatBox.Text) ||
                pertemuanBox.SelectedItem == null)
            {
                MessageBox.Show("Tidak ada data yang diinputkan. Mohon lengkapi semua data.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Medical_Record medical = new Medical_Record();
            medical.NamaPasien = namaPasien.Text;
            medical.Diagnosis = diagnosisBox.Text;
            medical.Perawatan = perawatanBox.Text;
            medical.TanggalRawat = pertemuanBox.SelectedItem.ToString().Substring(8);
            medical.Obat = obatBox.Text;

            result = MedicalRecordController.Create(medical);
            
            if (result > 0)
            {
                ResetForm();
                ShowData();
            }
        }

        private void ShowData()
        {
            lvwCatatan.Items.Clear();

            DataStore.MedicalRecordsList = MedicalRecordController.ReadAll();

            foreach (var medical in DataStore.MedicalRecordsList)
            {
                var item = new ListViewItem(medical.IdMedicalRecord.ToString());
                item.SubItems.Add(medical.NamaPasien.ToString());
                item.SubItems.Add(medical.Diagnosis.ToString());
                item.SubItems.Add(medical.Perawatan.ToString());
                item.SubItems.Add(medical.TanggalRawat.ToString());
                item.SubItems.Add(medical.Obat.ToString());

                lvwCatatan.Items.Add(item);
            }
        }

        private void namaPasien_TextChanged(object sender, EventArgs e)
        {
            UpdateListView(namaPasien.Text);
        }

        private void UpdateListView(string searchText)
        {
            listView1.Items.Clear();

            foreach (var pasien in DataStore.PatientsList)
            {
                string namaLengkap = pasien.NamaDepan + " " + pasien.NamaBelakang;

                if (namaLengkap.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    ListViewItem item = new ListViewItem(namaLengkap);
                    listView1.Items.Add(item);
                }
            }
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
            pertemuanBox.Items.Clear();
            infoLabel.Text = "";
            if (DataStore.AppointmentsList.Count() <= 0)
            {
                infoLabel.Text = "Tidak ada data pertemuan yang ditemukan";
                return;
            }

            bool foundAppointment = false;
            
            for (int i = 0; i < DataStore.AppointmentsList.Count(); i++)
            {
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddCatatanMedis();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lvwCatatan.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah catatan medis ini ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    Medical_Record catatan = DataStore.MedicalRecordsList[lvwCatatan.SelectedIndices[0]];

                    var result = MedicalRecordController.Delete(catatan);
                    if (result > 0)
                    {
                        ShowData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Tidak ada data catatan medis yang dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_deleteAll_Click(object sender, EventArgs e)
        {
            var konfirmasi = MessageBox.Show("Apakah semua data catatan medis ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (konfirmasi == DialogResult.Yes) {
                lvwCatatan.Clear();
                MedicalRecordController.DeleteAll();
                MedicalRecordController.ResetMedicalRecordAutoIncrement();
                ShowData();
            }
        }

        private void cariCatatanMedis_TextChanged(object sender, EventArgs e)
        {
            UpdateListViewForSearch(cariCatatanMedis.Text);
        }

        private void UpdateListViewForSearch(string searchText)
        {
            lvwCatatan.Items.Clear();

            if (string.IsNullOrEmpty(searchText))
            {
                ShowData();
                return;
            }

            List<Medical_Record> searchedMedicalRecords = new List<Medical_Record>();
            searchedMedicalRecords = MedicalRecordController.ReadAll();

            foreach (var med in searchedMedicalRecords)
            {
                string namaLengkap = med.NamaPasien;

                if (namaLengkap.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    var item = new ListViewItem(med.IdMedicalRecord.ToString());

                    item.SubItems.Add(med.NamaPasien.ToString());
                    item.SubItems.Add(med.Diagnosis.ToString());
                    item.SubItems.Add(med.Perawatan.ToString());
                    item.SubItems.Add(med.TanggalRawat.ToString());
                    item.SubItems.Add(med.Obat.ToString());

                    lvwCatatan.Items.Add(item);
                }
            }
        }

        private void patient_btn_update_Click(object sender, EventArgs e)
        {
            if (lvwCatatan.SelectedItems.Count > 0)
            {
                var index = lvwCatatan.SelectedIndices[0];
                Medical_Record selectedMedicalRecord = DataStore.MedicalRecordsList[index];

                UpdateCatatanMedis updateCatatanMedisForm = new UpdateCatatanMedis(selectedMedicalRecord, MedicalRecordController);
                updateCatatanMedisForm.ShowDialog();

                ShowData();
            }
            else
            {
                MessageBox.Show("Tidak ada data pembayaran yang dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

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
using Healthcare_Management_System.Forms.Update_Operation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Healthcare_Management_System
{
    public partial class pertemuanPage : Form
    {
        private AppointmentController AppointmentController;
        private DoctorController DoctorController;
        private PatientController PatientController;

        public pertemuanPage()
        {
            InitializeComponent();
            AppointmentController = new AppointmentController();
            DoctorController = new DoctorController();
            PatientController = new PatientController();

            DataStore.PatientsList = PatientController.ReadAll();
            DataStore.DoctorsList = DoctorController.ReadAll();

            InisialisasiListViewPatient();
            InisialisasiListView();
            addDoctorCollection();
            ShowData();
        }

        private void InisialisasiListView()
        {
            lvwPertemuan.View = View.Details;
            lvwPertemuan.FullRowSelect = true;
            lvwPertemuan.GridLines = true;
            lvwPertemuan.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwPertemuan.Columns.Add("Nama Pasien", 200, HorizontalAlignment.Left);
            lvwPertemuan.Columns.Add("Nama Dokter", 200, HorizontalAlignment.Left);
            lvwPertemuan.Columns.Add("Tanggal", 170, HorizontalAlignment.Left);
            lvwPertemuan.Columns.Add("Jam", 100, HorizontalAlignment.Left);
            lvwPertemuan.Columns.Add("Status", 140, HorizontalAlignment.Left);
        }

        private void ResetForm()
        {
            namaPasien.Clear();
            koleksiDokter.SelectedItem = null;
            statusBox.SelectedItem = null;
        }

        private void AddAppointment() 
        {
            if (string.IsNullOrWhiteSpace(namaPasien.Text) ||
                statusBox.SelectedItem == null ||
                koleksiDokter.SelectedItem == null)
            {
                MessageBox.Show("Tidak ada data yang diinputkan. Mohon lengkapi semua data.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int result = 0;

            Appointment appointment = new Appointment();
            appointment.NamaPasien = namaPasien.Text;
            appointment.NamaDokter = koleksiDokter.SelectedItem.ToString();
            appointment.TanggalPertemuan = dateTimePicker1.Value.ToShortDateString();
            appointment.JamPertemuan = dateTimePicker2.Value.ToShortTimeString();
            appointment.Status = statusBox.SelectedItem.ToString();

            result = AppointmentController.Create(appointment);
            if (result > 0)
            {
                ResetForm();
                ShowData();
            } 
        }

        private void ShowData()
        {
            lvwPertemuan.Items.Clear();
            DataStore.AppointmentsList = AppointmentController.ReadAll();

            foreach (var appointment in DataStore.AppointmentsList)
            {
                var item = new ListViewItem(appointment.IdAppointment.ToString());
                item.SubItems.Add(appointment.NamaPasien.ToString());
                item.SubItems.Add(appointment.NamaDokter.ToString());
                item.SubItems.Add(appointment.TanggalPertemuan.ToString());
                item.SubItems.Add(appointment.JamPertemuan.ToString());
                item.SubItems.Add(appointment.Status.ToString());

                lvwPertemuan.Items.Add(item);
            }
        }

        private void InisialisasiListViewPatient()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Nama Pasien", -2, HorizontalAlignment.Left);

            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            addPatientCollection();
        }

        private void addDoctorCollection()
        {
            if (DataStore.DoctorsList.Count() <= 0)
            {
                return;
            }

            for (int i = 0; i < DataStore.DoctorsList.Count(); i++)
            {
                koleksiDokter.Items.Add(DataStore.DoctorsList[i].NamaDepan.ToString() + " " + DataStore.DoctorsList[i].NamaBelakang.ToString());
            }
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

        private void addPatientCollection()
        {
            if (DataStore.PatientsList.Count() <= 0)
            {
                return;
            }
            UpdateListView("");
        }

        private void namaPasien_TextChanged(object sender, EventArgs e)
        {
            UpdateListView(namaPasien.Text);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string selectedName = listView1.SelectedItems[0].Text;
                namaPasien.Text = selectedName;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddAppointment();
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
            if (lvwPertemuan.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah pertemuan ini ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    var index = lvwPertemuan.SelectedIndices[0];
                    Appointment appointment = DataStore.AppointmentsList[index];

                    var result = AppointmentController.Delete(appointment);
                    if (result > 0) ShowData();
                }
            }
            else
            {
                MessageBox.Show("Tidak ada data pertemuan yang dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_deleteAll_Click(object sender, EventArgs e)
        {
            var konfirmasi = MessageBox.Show("Apakah semua data pertemuan ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (konfirmasi == DialogResult.Yes)
            {
                lvwPertemuan.Items.Clear();
                AppointmentController.DeleteAll();
                AppointmentController.ResetAppointmentAutoIncrement();
                ShowData();
            }
        }

        private void cariPertemuan_TextChanged(object sender, EventArgs e)
        {
            UpdateListViewForSearch(cariPertemuan.Text);
        }

        private void UpdateListViewForSearch(string searchText)
        {
            lvwPertemuan.Items.Clear();

            if (string.IsNullOrEmpty(searchText))
            {
                ShowData();
                return;
            }
            List<Appointment> searchedAppointments = new List<Appointment>();
            searchedAppointments = AppointmentController.ReadAll();

            foreach (var appointment in searchedAppointments)
            {
                string namaLengkap = appointment.NamaPasien;

                if (namaLengkap.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    var item = new ListViewItem(appointment.IdAppointment.ToString());

                    item.SubItems.Add(appointment.NamaPasien.ToString());
                    item.SubItems.Add(appointment.NamaDokter.ToString());
                    item.SubItems.Add(appointment.TanggalPertemuan.ToString());
                    item.SubItems.Add(appointment.JamPertemuan.ToString());
                    item.SubItems.Add(appointment.Status.ToString());

                    lvwPertemuan.Items.Add(item);
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (lvwPertemuan.SelectedItems.Count > 0)
            {
                var index = lvwPertemuan.SelectedIndices[0];
                Appointment selectedAppointment = DataStore.AppointmentsList[index];

                UpdatePertemuan updatePertemuanForm = new UpdatePertemuan(selectedAppointment, AppointmentController);
                updatePertemuanForm.ShowDialog();

                ShowData();
            }
            else
                MessageBox.Show("Tidak ada data pertemuan yang dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }
    }
}

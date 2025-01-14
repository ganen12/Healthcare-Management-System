using Healthcare_Management_System.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healthcare_Management_System.Forms.Update_Operation
{
    public partial class UpdatePertemuan : Form
    {
        private Appointment appointment;
        private AppointmentController AppointmentController;
        public UpdatePertemuan()
        {
            InitializeComponent();
        }

        public UpdatePertemuan(Appointment appointment, AppointmentController controller) : this()
        {
            this.appointment = appointment;
            this.AppointmentController = controller;
            InisialisasiListViewPatient();
            addDoctorCollection();
            ShowCurrentAppointmentData();
        }
        private void ShowCurrentAppointmentData()
        {
            namaPasien.Text = appointment.NamaPasien.ToString();

            int selectedDoctorIndex = koleksiDokter.Items.IndexOf(appointment.NamaDokter);
            koleksiDokter.SelectedIndex = selectedDoctorIndex;

            int selectedStatusIndex = statusBox.Items.IndexOf(appointment.Status);
            statusBox.SelectedIndex = selectedStatusIndex;

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void addDoctorCollection()
        {
            if (DataStore.DoctorsList.Count() <= 0)
            {
                return;
            }
            // System.Object[] ItemObject = new System.Object[DataStore.DoctorsList.Count()];
            for (int i = 0; i < DataStore.DoctorsList.Count(); i++)
            {
                // ItemObject[i] = DataStore.DoctorsList[i];
                koleksiDokter.Items.Add(DataStore.DoctorsList[i].NamaDepan.ToString() + " " + DataStore.DoctorsList[i].NamaBelakang.ToString());
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

        private void cancelBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void appointment_btn_update_Click_1(object sender, EventArgs e)
        {
            appointment.NamaPasien = namaPasien.Text.ToString();
            appointment.NamaDokter = koleksiDokter.SelectedItem.ToString();
            appointment.TanggalPertemuan = dateTimePicker1.Value.ToShortDateString();
            appointment.JamPertemuan = dateTimePicker2.Value.ToShortTimeString();
            appointment.Status = statusBox.SelectedItem.ToString();

            int result = 0;
            result = AppointmentController.Update(appointment);

            if (result > 0)
            {
                MessageBox.Show("Data pertemuan berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}

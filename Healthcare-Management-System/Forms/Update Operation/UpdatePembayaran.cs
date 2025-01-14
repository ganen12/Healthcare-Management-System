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
    public partial class UpdatePembayaran : Form
    {
        private Billing billing;
        private BillingController BillingController;
        public UpdatePembayaran()
        {
            InitializeComponent();
        }
        public UpdatePembayaran(Billing billing, BillingController controller) : this()
        {
            this.billing = billing;
            this.BillingController = controller;
            InisialisasiListViewPatient();
            ShowCurrentBillingData();

            infoLabel.Text = "";
            sudahBayar.CheckedChanged += RadioButton_CheckedChanged;
            belumBayar.CheckedChanged += RadioButton_CheckedChanged;


        }
        private void InisialisasiListViewPatient()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Nama Pasien", -2, HorizontalAlignment.Left);

            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            addPatientCollection();
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
        private void ShowCurrentBillingData()
        {
            namaPasien.Text = billing.NamaPasien.ToString();

            pertemuanBox.Items.Insert(0, "-- Choose Appointment --");
            pertemuanBox.SelectedIndex = 0;

            hargaText.Text = billing.JumlahPembayaran.ToString();
            if (billing.StatusPembayaran == "Sudah Bayar")
            {
                sudahBayar.Checked = true;
                belumBayar.Checked = false;
            } else
            {
                sudahBayar.Checked = false;
                belumBayar.Checked = true;
            }

        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                if (radioButton == sudahBayar)
                {
                    belumBayar.Checked = false;
                }
                else if (radioButton == belumBayar)
                {
                    sudahBayar.Checked = false;
                }
            }
        }
        private void patient_btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(namaPasien.Text) ||
                pertemuanBox.SelectedItem == null)
            {
                MessageBox.Show("Tidak ada data yang diinputkan. Mohon lengkapi semua data.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            billing.NamaPasien = namaPasien.Text;
            if (sudahBayar.Checked)
            {
                billing.StatusPembayaran = "Sudah Bayar";
            }
            else if (belumBayar.Checked)
            {
                billing.StatusPembayaran = "Belum Bayar";
            }
            billing.TanggalPembayaran = pertemuanBox.SelectedItem.ToString().Substring(8);
            billing.JumlahPembayaran = int.Parse(hargaText.Text.ToString());

            int result = 0;
            result = BillingController.Update(billing);

            if (result > 0)
            {
                MessageBox.Show("Data pembayaran berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
using Healthcare_Management_System.Forms.Update_Operation;

namespace Healthcare_Management_System
{
    public partial class pembayaranPage : Form
    {
        private AppointmentController AppointmentController;
        private PatientController PatientController;
        private BillingController BillingController;

        public pembayaranPage()
        {
            InitializeComponent();

            AppointmentController = new AppointmentController();
            PatientController = new PatientController();
            BillingController = new BillingController();

            DataStore.AppointmentsList = AppointmentController.ReadAll();
            DataStore.PatientsList = PatientController.ReadAll();

            InisialisasiListViewPatient();
            InisialisasiListView();
            infoLabel.Text = null;
            pertemuanBox.Items.Insert(0, "-- Choose Appointment --");
            pertemuanBox.SelectedIndex = 0;

            sudahBayar.CheckedChanged += RadioButton_CheckedChanged;
            belumBayar.CheckedChanged += RadioButton_CheckedChanged;

            ShowData();
        }

        private void InisialisasiListView()
        {
            lvwPembayaran.View = View.Details;
            lvwPembayaran.FullRowSelect = true;
            lvwPembayaran.GridLines = true;
            lvwPembayaran.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwPembayaran.Columns.Add("Nama Pasien", 200, HorizontalAlignment.Left);
            lvwPembayaran.Columns.Add("Tanggal Pertemuan", 170, HorizontalAlignment.Left);
            lvwPembayaran.Columns.Add("Harga", 170, HorizontalAlignment.Left);
            lvwPembayaran.Columns.Add("Status", 170, HorizontalAlignment.Left);
        }

        private void InisialisasiListViewPatient()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Nama Pasien", -2, HorizontalAlignment.Left);

            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            addPatientCollection();
        }

        private void addAppointmentCollection(string namaPasien)
        {
            pertemuanBox.Items.Clear();

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

        private void addPatientCollection()
        {
            if (DataStore.PatientsList.Count() <= 0)
            {
                return;
            }
            UpdateListView("");
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

                addAppointmentCollection(selectedName);
            }
        }

        private void AddBilling()
        {

            if (string.IsNullOrWhiteSpace(namaPasien.Text) ||
                pertemuanBox.SelectedItem == null)
            {
                MessageBox.Show("Tidak ada data yang diinputkan. Mohon lengkapi semua data.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int result = 0;

            Billing billing = new Billing();
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

            result = BillingController.Create(billing);
            if (result > 0)
            {
                ResetForm();
                ShowData();
            }
        }

        private void ResetForm()
        {
            hargaText.Clear();
            pertemuanBox.SelectedItem = null;
            if (sudahBayar.Checked)
            {
                sudahBayar.Checked = false;
            }

            if (belumBayar.Checked)
            {
                belumBayar.Checked = false;
            }
        }

        private void ShowData()
        {
            lvwPembayaran.Items.Clear();
            DataStore.BillingsList = BillingController.ReadAll();

            foreach (var billing in DataStore.BillingsList)
            {
                var item = new ListViewItem(billing.IdBilling.ToString());
                item.SubItems.Add(billing.NamaPasien.ToString());
                item.SubItems.Add(billing.TanggalPembayaran.ToString());
                item.SubItems.Add(billing.JumlahPembayaran.ToString());
                item.SubItems.Add(billing.StatusPembayaran.ToString());

                lvwPembayaran.Items.Add(item);
            }
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

        private void btn_add_patient_Click(object sender, EventArgs e)
        {
            infoLabel.Text = null;
            AddBilling();
        }

        private void patient_btn_show_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void patient_btn_reset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void patient_btn_delete_Click(object sender, EventArgs e)
        {
            if (lvwPembayaran.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah pembayaran ini ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    var index = lvwPembayaran.SelectedIndices[0];

                    Billing billing = DataStore.BillingsList[index];

                    var result = BillingController.Delete(billing);
                    if(result > 0) ShowData();
                }
            }
            else
            {
                MessageBox.Show("Tidak ada data pembayaran yang dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void patient_btn_deleteAll_Click(object sender, EventArgs e)
        {
            var konfirmasi = MessageBox.Show("Apakah semua data catatan medis ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (konfirmasi == DialogResult.Yes)
            {
                lvwPembayaran.Clear();
                BillingController.DeleteAll();
                BillingController.ResetBillingAutoIncrement();
                ShowData();
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

        private void cariPembayaran_TextChanged(object sender, EventArgs e)
        {
            UpdateListViewForSearch(cariPembayaran.Text);
        }

        private void UpdateListViewForSearch(string searchText)
        {
            lvwPembayaran.Items.Clear();

            if (string.IsNullOrEmpty(searchText))
            {
                ShowData();
                return;
            }

            List<Billing> searchedBillings = new List<Billing>();
            searchedBillings = BillingController.ReadAll();

            foreach (var billing in searchedBillings)
            {
                string namaLengkap = billing.NamaPasien;

                if (namaLengkap.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    var item = new ListViewItem(billing.IdBilling.ToString());

                    item.SubItems.Add(billing.NamaPasien.ToString());
                    item.SubItems.Add(billing.TanggalPembayaran.ToString());
                    item.SubItems.Add(billing.JumlahPembayaran.ToString());
                    item.SubItems.Add(billing.StatusPembayaran.ToString());

                    lvwPembayaran.Items.Add(item);
                }
            }
        }

        private void patient_btn_update_Click(object sender, EventArgs e)
        {
            if (lvwPembayaran.SelectedItems.Count > 0)
            {
                var index = lvwPembayaran.SelectedIndices[0];
                Billing selectedBilling = DataStore.BillingsList[index];

                UpdatePembayaran updatePembayaranForm= new UpdatePembayaran(selectedBilling, BillingController);
                updatePembayaranForm.ShowDialog();

                ShowData();
            }
            else
            {
                MessageBox.Show("Tidak ada data pembayaran yang dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

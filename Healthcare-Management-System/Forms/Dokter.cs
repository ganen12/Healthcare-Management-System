using Healthcare_Management_System.Controller;
using Healthcare_Management_System.Forms;
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
using Healthcare_Management_System.Forms.Update_Operation;

namespace Healthcare_Management_System
{
    public partial class dokterPage : Form
    {
        private DoctorController DoctorController;
        public dokterPage()
        {
            InitializeComponent();
            DoctorController = new DoctorController();
            InisialiasasiListView();
            ShowData();
        }

        private void InisialiasasiListView()
        {
            lvwDoctor.View = View.Details;
            lvwDoctor.FullRowSelect = true;
            lvwDoctor.GridLines = true;
            lvwDoctor.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwDoctor.Columns.Add("Nama", 200, HorizontalAlignment.Left);
            lvwDoctor.Columns.Add("Spesialisasi", 180, HorizontalAlignment.Left);
            lvwDoctor.Columns.Add("Jadwal", 180, HorizontalAlignment.Left);
        }

        private void AddDoctor()
        {
            if (string.IsNullOrWhiteSpace(namaDepan.Text) ||
                string.IsNullOrWhiteSpace(namaBelakang.Text) ||
                spesialisasiBox.SelectedItem == null)
            {
                MessageBox.Show("Tidak ada data yang diinputkan. Mohon lengkapi semua data.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int result = 0;

            Doctor dokter = new Doctor();
            dokter.NamaDepan = namaDepan.Text;
            dokter.NamaBelakang = namaBelakang.Text;
            dokter.jadwalArr = "";
            dokter.Spesialisasi = spesialisasiBox.SelectedItem.ToString();

            result = DoctorController.Create(dokter);
            if (result > 0)
            {
                ResetForm();
                ShowData();
            }
            
            var msg = "Data dokter berhasil disimpan.";

            ResetForm();
        }

        private void ResetForm()
        {
            namaDepan.Clear();
            namaBelakang.Clear();
            spesialisasiBox.SelectedItem = null;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddDoctor();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ShowData()
        {
            lvwDoctor.Items.Clear();

            DataStore.DoctorsList = DoctorController.ReadAll();
            foreach (var dokter in DataStore.DoctorsList)
            {
                string jadwalDokter = string.Join(", ", dokter.jadwalArr);;

                var item = new ListViewItem(dokter.IdDoctor.ToString());

                item.SubItems.Add(dokter.NamaDepan.ToString() + " " + dokter.NamaBelakang.ToString());
                item.SubItems.Add(dokter.Spesialisasi.ToString());
                item.SubItems.Add(jadwalDokter);

                lvwDoctor.Items.Add(item);
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lvwDoctor.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah dokter ini ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    Doctor dokter = DataStore.DoctorsList[lvwDoctor.SelectedIndices[0]];

                    var result = DoctorController.Delete(dokter);
                    if (result > 0) ShowData();
                }
            }
            else
            {
                MessageBox.Show("Tidak ada data dokter yang dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_deleteAll_Click(object sender, EventArgs e)
        {
            var konfirmasi = MessageBox.Show("Apakah semua data catatan medis ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (konfirmasi == DialogResult.Yes)
            {
                DoctorController.DeleteAll();
                DoctorController.ResetDoctorAutoIncrement();
                ShowData();
            }
        }

        private void btn_add_jadwal_Click(object sender, EventArgs e)
        {
            if (lvwDoctor.SelectedItems.Count > 0)
            {
                var index = lvwDoctor.SelectedIndices[0];
                Doctor selectedDoctor = DataStore.DoctorsList[index];
                string nama = lvwDoctor.Items[index].SubItems[1].Text;

                JadwalDokterForm jadwalDokter = new JadwalDokterForm("Tambah Jadwal Dokter", nama, selectedDoctor, DoctorController);
                jadwalDokter.ShowDialog();

                ShowData();
            }
            else
            {
                MessageBox.Show("Tidak ada data dokter yang dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (lvwDoctor.SelectedItems.Count > 0)
            {
                var index = lvwDoctor.SelectedIndices[0];
                Doctor selectedDoctor = DataStore.DoctorsList[index];

                UpdateDokter updateDokterForm= new UpdateDokter(selectedDoctor, DoctorController); 
                updateDokterForm.ShowDialog();

                ShowData();
            }
            else
            {
                MessageBox.Show("Tidak ada data pasien yang dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cariDoctor_TextChanged(object sender, EventArgs e)
        {
            UpdateListView(cariDokter.Text);
        }

        private void UpdateListView(string searchText)
        {
            lvwDoctor.Items.Clear();
            if (string.IsNullOrEmpty(searchText))
            {
                ShowData();
                return;
            }

            List<Doctor> searchedDoctors = new List<Doctor>();
            searchedDoctors = DoctorController.ReadAll();

            foreach (var dokter in searchedDoctors)
            {
                string namaLengkap = dokter.NamaDepan + " " + dokter.NamaBelakang;

                if (namaLengkap.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    var item = new ListViewItem(dokter.IdDoctor.ToString());

                    item.SubItems.Add(dokter.NamaDepan.ToString() + " " + dokter.NamaBelakang.ToString());
                    item.SubItems.Add(dokter.Spesialisasi.ToString());
                    item.SubItems.Add(dokter.jadwalArr.ToString());

                    lvwDoctor.Items.Add(item);
                }
            }
        }
    }
}

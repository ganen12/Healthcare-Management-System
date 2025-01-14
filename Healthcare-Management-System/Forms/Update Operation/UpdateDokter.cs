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
    public partial class UpdateDokter : Form
    {
        private string keseluruhanJadwalDokter { get; set; }
        public List<string> jadwalArr = new List<string>();
        private string nama;
        
        public Doctor doctor;
        private DoctorController DoctorController;
        public UpdateDokter()
        {
            InitializeComponent();
        }

        public UpdateDokter(Doctor doctor, DoctorController controller) : this()
        {
            this.doctor = doctor;
            this.DoctorController = controller;
            InisialisasiListView();
            ShowCurrentDoctorData();
            InitializeJadwalData();
            ShowData();
        }

        private void ShowCurrentDoctorData()
        {
            namaDepanTxt.Text = doctor.NamaDepan;
            namaBelakangTxt.Text = doctor.NamaBelakang;
            /*
            int indexAsuransi = spesialisasiBox.Items.IndexOf(patient.Asuransi);
            if (indexAsuransi != -1) // Make sure the item exists
            {
                patient_comboBox_jenisKelamin.SelectedIndex = indexAsuransi;
            }
            */
        }
        private void InisialisasiListView()
        {
            lvwDoctor.View = View.Details;
            lvwDoctor.FullRowSelect = true;
            lvwDoctor.GridLines = true;
            lvwDoctor.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwDoctor.Columns.Add("Jadwal", 180, HorizontalAlignment.Left);
        }

        private void InitializeJadwalData()
        {
            if (doctor.jadwalArr != null)
            {
                jadwalArr = doctor.jadwalArr.ToString().Split(',').ToList();
                keseluruhanJadwalDokter = string.Join(", ", jadwalArr);
            }
        }

        private void ShowData()
        {
            lvwDoctor.Items.Clear();

            foreach (string jad in jadwalArr)
            {
                var noUrut = lvwDoctor.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(jad.ToString());

                lvwDoctor.Items.Add(item);
            }
        }

        private void patient_btn_update_Click(object sender, EventArgs e)
        {
            doctor.NamaDepan = namaDepanTxt.Text.ToString();
            doctor.NamaBelakang = namaBelakangTxt.Text.ToString();
            if (spesialisasiBox.SelectedItem != null)
            {
                doctor.Spesialisasi = spesialisasiBox.SelectedItem.ToString();
            }
            doctor.jadwalArr = keseluruhanJadwalDokter;


            int result = 0;
            result = DoctorController.Update(doctor);

            if (result > 0)
            {
                MessageBox.Show("Data dokter berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string hari = hariComboBox.SelectedItem.ToString();
            string shift = shiftComboBox.SelectedItem.ToString();
            string hariAndShift = $"{hari} {shift}";

            jadwalArr.Add(hariAndShift);

            keseluruhanJadwalDokter = string.Join(", ", jadwalArr);
            ShowData();
        }
    }
}

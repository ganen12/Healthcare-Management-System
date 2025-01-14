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

namespace Healthcare_Management_System.Forms
{
    public delegate void CreateUpdateEventHandler(Doctor doctor);
    
    public partial class JadwalDokterForm : Form
    {
        private string keseluruhanJadwalDokter {  get; set; }
        public List<string> jadwalArr = new List<string>();
        private string nama;
        private Doctor doctor;
        private DoctorController DoctorController;

        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;

        public JadwalDokterForm()
        {
            InitializeComponent();

        }
        public JadwalDokterForm(string title, string nama, Doctor doctor, DoctorController controller) : this ()
        {
            this.Text = title;
            this.nama = nama;
            this.doctor = doctor;
            this.DoctorController = controller;
            labelNama.Text = $"Add jadwal for {doctor.NamaDepan} {doctor.NamaBelakang}";
            InisialisasiListView();
            InitializeJadwalData();
            ShowData();
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
            if (doctor != null) {
                jadwalArr = doctor.jadwalArr.ToString().Split(',').ToList();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string hari = hariComboBox.SelectedItem.ToString();
            string shift = shiftComboBox.SelectedItem.ToString();
            string hariAndShift = $"{hari} {shift}";
                
            jadwalArr.Add(hariAndShift);

            keseluruhanJadwalDokter = string.Join(", ", jadwalArr);
            doctor.jadwalArr = keseluruhanJadwalDokter;

            int result = 0;

            result = DoctorController.UpdateJadwalSaja(doctor);
            if (result > 0)
            {
                ShowData();
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

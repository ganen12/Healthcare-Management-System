namespace Healthcare_Management_System.Forms.Update_Operation
{
    partial class UpdateDokter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.namaBelakangTxt = new System.Windows.Forms.TextBox();
            this.nama_belakang = new System.Windows.Forms.Label();
            this.namaDepanTxt = new System.Windows.Forms.TextBox();
            this.nama_depan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.spesialisasiBox = new System.Windows.Forms.ComboBox();
            this.lvwDoctor = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.hariTxt = new System.Windows.Forms.Label();
            this.shiftComboBox = new System.Windows.Forms.ComboBox();
            this.hariComboBox = new System.Windows.Forms.ComboBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.patient_btn_update = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namaBelakangTxt
            // 
            this.namaBelakangTxt.Location = new System.Drawing.Point(200, 50);
            this.namaBelakangTxt.Name = "namaBelakangTxt";
            this.namaBelakangTxt.Size = new System.Drawing.Size(124, 20);
            this.namaBelakangTxt.TabIndex = 34;
            // 
            // nama_belakang
            // 
            this.nama_belakang.AutoSize = true;
            this.nama_belakang.Location = new System.Drawing.Point(197, 23);
            this.nama_belakang.Name = "nama_belakang";
            this.nama_belakang.Size = new System.Drawing.Size(83, 13);
            this.nama_belakang.TabIndex = 33;
            this.nama_belakang.Text = "Nama Belakang";
            // 
            // namaDepanTxt
            // 
            this.namaDepanTxt.Location = new System.Drawing.Point(27, 50);
            this.namaDepanTxt.Name = "namaDepanTxt";
            this.namaDepanTxt.Size = new System.Drawing.Size(125, 20);
            this.namaDepanTxt.TabIndex = 32;
            // 
            // nama_depan
            // 
            this.nama_depan.AutoSize = true;
            this.nama_depan.Location = new System.Drawing.Point(24, 23);
            this.nama_depan.Name = "nama_depan";
            this.nama_depan.Size = new System.Drawing.Size(70, 13);
            this.nama_depan.TabIndex = 31;
            this.nama_depan.Text = "Nama Depan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Spesialisasi";
            // 
            // spesialisasiBox
            // 
            this.spesialisasiBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spesialisasiBox.FormattingEnabled = true;
            this.spesialisasiBox.Items.AddRange(new object[] {
            "Dokter Umum",
            "Dokter Gigi",
            "Dokter Spesialis Bedah (Surgeon)",
            "Dokter Spesialis Anak (Pediatrik)",
            "Dokter Spesialis Kandungan (Obstetri dan Ginekologi)",
            "Dokter Spesialis Penyakit Dalam (Internis)",
            "Dokter Spesialis Kulit dan Kelamin (Dermatologi dan Venereologi)",
            "Dokter Spesialis THT (Telinga, Hidung, Tenggorokan)",
            "Dokter Spesialis Saraf (Neurologi)",
            "Dokter Spesialis Jantung dan Pembuluh Darah (Kardiologi)",
            "Dokter Spesialis Mata (Oftalmologi)",
            "Dokter Spesialis Paru (Pulmonologi)",
            "Dokter Spesialis Psikiatri",
            "Dokter Spesialis Urologi",
            "Dokter Spesialis Gizi Klinik"});
            this.spesialisasiBox.Location = new System.Drawing.Point(27, 128);
            this.spesialisasiBox.Name = "spesialisasiBox";
            this.spesialisasiBox.Size = new System.Drawing.Size(191, 21);
            this.spesialisasiBox.TabIndex = 40;
            // 
            // lvwDoctor
            // 
            this.lvwDoctor.HideSelection = false;
            this.lvwDoctor.Location = new System.Drawing.Point(27, 241);
            this.lvwDoctor.Name = "lvwDoctor";
            this.lvwDoctor.Size = new System.Drawing.Size(294, 180);
            this.lvwDoctor.TabIndex = 42;
            this.lvwDoctor.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Shift";
            // 
            // hariTxt
            // 
            this.hariTxt.AutoSize = true;
            this.hariTxt.Location = new System.Drawing.Point(26, 178);
            this.hariTxt.Name = "hariTxt";
            this.hariTxt.Size = new System.Drawing.Size(26, 13);
            this.hariTxt.TabIndex = 45;
            this.hariTxt.Text = "Hari";
            // 
            // shiftComboBox
            // 
            this.shiftComboBox.FormattingEnabled = true;
            this.shiftComboBox.Items.AddRange(new object[] {
            "pagi",
            "siang",
            "sore",
            "malam"});
            this.shiftComboBox.Location = new System.Drawing.Point(202, 203);
            this.shiftComboBox.Name = "shiftComboBox";
            this.shiftComboBox.Size = new System.Drawing.Size(121, 21);
            this.shiftComboBox.TabIndex = 44;
            // 
            // hariComboBox
            // 
            this.hariComboBox.FormattingEnabled = true;
            this.hariComboBox.Items.AddRange(new object[] {
            "senin",
            "selasa",
            "rabu",
            "kamis",
            "jumat",
            "sabtu",
            "minggu"});
            this.hariComboBox.Location = new System.Drawing.Point(29, 203);
            this.hariComboBox.Name = "hariComboBox";
            this.hariComboBox.Size = new System.Drawing.Size(121, 21);
            this.hariComboBox.TabIndex = 43;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(184, 515);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(137, 32);
            this.cancelBtn.TabIndex = 48;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // patient_btn_update
            // 
            this.patient_btn_update.Location = new System.Drawing.Point(29, 515);
            this.patient_btn_update.Name = "patient_btn_update";
            this.patient_btn_update.Size = new System.Drawing.Size(132, 32);
            this.patient_btn_update.TabIndex = 47;
            this.patient_btn_update.Text = "Update";
            this.patient_btn_update.UseVisualStyleBackColor = true;
            this.patient_btn_update.Click += new System.EventHandler(this.patient_btn_update_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(236, 427);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 30);
            this.btnAdd.TabIndex = 49;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // UpdateDokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 573);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.patient_btn_update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hariTxt);
            this.Controls.Add(this.shiftComboBox);
            this.Controls.Add(this.hariComboBox);
            this.Controls.Add(this.lvwDoctor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.spesialisasiBox);
            this.Controls.Add(this.namaBelakangTxt);
            this.Controls.Add(this.nama_belakang);
            this.Controls.Add(this.namaDepanTxt);
            this.Controls.Add(this.nama_depan);
            this.Name = "UpdateDokter";
            this.Text = "UpdateDokter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namaBelakangTxt;
        private System.Windows.Forms.Label nama_belakang;
        private System.Windows.Forms.TextBox namaDepanTxt;
        private System.Windows.Forms.Label nama_depan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox spesialisasiBox;
        private System.Windows.Forms.ListView lvwDoctor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hariTxt;
        private System.Windows.Forms.ComboBox shiftComboBox;
        private System.Windows.Forms.ComboBox hariComboBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button patient_btn_update;
        private System.Windows.Forms.Button btnAdd;
    }
}
namespace Healthcare_Management_System
{
    partial class Pasien
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
            this.patientpanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cariPasien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.asuransiBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.patient_comboBox_jenisKelamin = new System.Windows.Forms.ComboBox();
            this.patient_btn_deleteAll = new System.Windows.Forms.Button();
            this.patient_btn_show = new System.Windows.Forms.Button();
            this.lvwPatient = new System.Windows.Forms.ListView();
            this.patient_btn_delete = new System.Windows.Forms.Button();
            this.patient_btn_update = new System.Windows.Forms.Button();
            this.patient_btn_reset = new System.Windows.Forms.Button();
            this.btn_add_patient = new System.Windows.Forms.Button();
            this.alamatTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.noTeleponTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_tanggal_lahir = new System.Windows.Forms.Label();
            this.namaBelakangTxt = new System.Windows.Forms.TextBox();
            this.nama_belakang = new System.Windows.Forms.Label();
            this.namaDepanTxt = new System.Windows.Forms.TextBox();
            this.nama_depan = new System.Windows.Forms.Label();
            this.patientpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientpanel
            // 
            this.patientpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientpanel.Controls.Add(this.label5);
            this.patientpanel.Controls.Add(this.cariPasien);
            this.patientpanel.Controls.Add(this.label4);
            this.patientpanel.Controls.Add(this.asuransiBox);
            this.patientpanel.Controls.Add(this.dateTimePicker1);
            this.patientpanel.Controls.Add(this.patient_comboBox_jenisKelamin);
            this.patientpanel.Controls.Add(this.patient_btn_deleteAll);
            this.patientpanel.Controls.Add(this.patient_btn_show);
            this.patientpanel.Controls.Add(this.lvwPatient);
            this.patientpanel.Controls.Add(this.patient_btn_delete);
            this.patientpanel.Controls.Add(this.patient_btn_update);
            this.patientpanel.Controls.Add(this.patient_btn_reset);
            this.patientpanel.Controls.Add(this.btn_add_patient);
            this.patientpanel.Controls.Add(this.alamatTxt);
            this.patientpanel.Controls.Add(this.label3);
            this.patientpanel.Controls.Add(this.label2);
            this.patientpanel.Controls.Add(this.noTeleponTxt);
            this.patientpanel.Controls.Add(this.label1);
            this.patientpanel.Controls.Add(this.label_tanggal_lahir);
            this.patientpanel.Controls.Add(this.namaBelakangTxt);
            this.patientpanel.Controls.Add(this.nama_belakang);
            this.patientpanel.Controls.Add(this.namaDepanTxt);
            this.patientpanel.Controls.Add(this.nama_depan);
            this.patientpanel.Location = new System.Drawing.Point(134, 31);
            this.patientpanel.Name = "patientpanel";
            this.patientpanel.Size = new System.Drawing.Size(831, 607);
            this.patientpanel.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(629, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Cari Pasien";
            // 
            // cariPasien
            // 
            this.cariPasien.Location = new System.Drawing.Point(632, 212);
            this.cariPasien.Name = "cariPasien";
            this.cariPasien.Size = new System.Drawing.Size(179, 20);
            this.cariPasien.TabIndex = 30;
            this.cariPasien.TextChanged += new System.EventHandler(this.cariPasien_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Asuransi";
            // 
            // asuransiBox
            // 
            this.asuransiBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.asuransiBox.FormattingEnabled = true;
            this.asuransiBox.Items.AddRange(new object[] {
            "Asuransi BPJS Kesehatan",
            "Asuransi Sinarmas",
            "Asuransi Manulife",
            "Asuransi Cigna",
            "Asuransi AIA",
            "Asuransi Prudential",
            "Asuransi Allianz",
            "Asuransi BRI Life",
            "Asuransi Sun Life"});
            this.asuransiBox.Location = new System.Drawing.Point(388, 139);
            this.asuransiBox.Name = "asuransiBox";
            this.asuransiBox.Size = new System.Drawing.Size(191, 21);
            this.asuransiBox.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(35, 139);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // patient_comboBox_jenisKelamin
            // 
            this.patient_comboBox_jenisKelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patient_comboBox_jenisKelamin.FormattingEnabled = true;
            this.patient_comboBox_jenisKelamin.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.patient_comboBox_jenisKelamin.Location = new System.Drawing.Point(176, 138);
            this.patient_comboBox_jenisKelamin.Name = "patient_comboBox_jenisKelamin";
            this.patient_comboBox_jenisKelamin.Size = new System.Drawing.Size(100, 21);
            this.patient_comboBox_jenisKelamin.TabIndex = 22;
            // 
            // patient_btn_deleteAll
            // 
            this.patient_btn_deleteAll.BackColor = System.Drawing.Color.Tomato;
            this.patient_btn_deleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patient_btn_deleteAll.Location = new System.Drawing.Point(733, 473);
            this.patient_btn_deleteAll.Name = "patient_btn_deleteAll";
            this.patient_btn_deleteAll.Size = new System.Drawing.Size(78, 32);
            this.patient_btn_deleteAll.TabIndex = 20;
            this.patient_btn_deleteAll.Text = "Delete All";
            this.patient_btn_deleteAll.UseVisualStyleBackColor = false;
            this.patient_btn_deleteAll.Click += new System.EventHandler(this.patient_btn_deleteAll_Click);
            // 
            // patient_btn_show
            // 
            this.patient_btn_show.BackColor = System.Drawing.Color.Wheat;
            this.patient_btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patient_btn_show.Location = new System.Drawing.Point(35, 473);
            this.patient_btn_show.Name = "patient_btn_show";
            this.patient_btn_show.Size = new System.Drawing.Size(78, 32);
            this.patient_btn_show.TabIndex = 19;
            this.patient_btn_show.Text = "Show";
            this.patient_btn_show.UseVisualStyleBackColor = false;
            this.patient_btn_show.Click += new System.EventHandler(this.patient_btn_show_Click);
            // 
            // lvwPatient
            // 
            this.lvwPatient.HideSelection = false;
            this.lvwPatient.Location = new System.Drawing.Point(35, 250);
            this.lvwPatient.Name = "lvwPatient";
            this.lvwPatient.Size = new System.Drawing.Size(776, 196);
            this.lvwPatient.TabIndex = 18;
            this.lvwPatient.UseCompatibleStateImageBehavior = false;
            // 
            // patient_btn_delete
            // 
            this.patient_btn_delete.BackColor = System.Drawing.Color.Tomato;
            this.patient_btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patient_btn_delete.Location = new System.Drawing.Point(631, 473);
            this.patient_btn_delete.Name = "patient_btn_delete";
            this.patient_btn_delete.Size = new System.Drawing.Size(78, 32);
            this.patient_btn_delete.TabIndex = 17;
            this.patient_btn_delete.Text = "Delete";
            this.patient_btn_delete.UseVisualStyleBackColor = false;
            this.patient_btn_delete.Click += new System.EventHandler(this.patient_btn_delete_Click);
            // 
            // patient_btn_update
            // 
            this.patient_btn_update.BackColor = System.Drawing.Color.Wheat;
            this.patient_btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patient_btn_update.Location = new System.Drawing.Point(531, 473);
            this.patient_btn_update.Name = "patient_btn_update";
            this.patient_btn_update.Size = new System.Drawing.Size(78, 32);
            this.patient_btn_update.TabIndex = 16;
            this.patient_btn_update.Text = "Update";
            this.patient_btn_update.UseVisualStyleBackColor = false;
            this.patient_btn_update.Click += new System.EventHandler(this.patient_btn_update_Click);
            // 
            // patient_btn_reset
            // 
            this.patient_btn_reset.BackColor = System.Drawing.Color.Honeydew;
            this.patient_btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patient_btn_reset.Location = new System.Drawing.Point(141, 205);
            this.patient_btn_reset.Name = "patient_btn_reset";
            this.patient_btn_reset.Size = new System.Drawing.Size(78, 32);
            this.patient_btn_reset.TabIndex = 15;
            this.patient_btn_reset.Text = "Reset";
            this.patient_btn_reset.UseVisualStyleBackColor = false;
            this.patient_btn_reset.Click += new System.EventHandler(this.patient_btn_reset_Click);
            // 
            // btn_add_patient
            // 
            this.btn_add_patient.BackColor = System.Drawing.Color.LightGreen;
            this.btn_add_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_patient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_add_patient.Location = new System.Drawing.Point(35, 205);
            this.btn_add_patient.Name = "btn_add_patient";
            this.btn_add_patient.Size = new System.Drawing.Size(78, 32);
            this.btn_add_patient.TabIndex = 13;
            this.btn_add_patient.Text = "Add";
            this.btn_add_patient.UseVisualStyleBackColor = false;
            this.btn_add_patient.Click += new System.EventHandler(this.btn_add_patient_Click);
            // 
            // alamatTxt
            // 
            this.alamatTxt.Location = new System.Drawing.Point(519, 61);
            this.alamatTxt.Name = "alamatTxt";
            this.alamatTxt.Size = new System.Drawing.Size(170, 20);
            this.alamatTxt.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Jenis Kelamin";
            // 
            // noTeleponTxt
            // 
            this.noTeleponTxt.Location = new System.Drawing.Point(388, 61);
            this.noTeleponTxt.Name = "noTeleponTxt";
            this.noTeleponTxt.Size = new System.Drawing.Size(100, 20);
            this.noTeleponTxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nomor Telepon";
            // 
            // label_tanggal_lahir
            // 
            this.label_tanggal_lahir.AutoSize = true;
            this.label_tanggal_lahir.Location = new System.Drawing.Point(32, 111);
            this.label_tanggal_lahir.Name = "label_tanggal_lahir";
            this.label_tanggal_lahir.Size = new System.Drawing.Size(72, 13);
            this.label_tanggal_lahir.TabIndex = 4;
            this.label_tanggal_lahir.Text = "Tanggal Lahir";
            // 
            // namaBelakangTxt
            // 
            this.namaBelakangTxt.Location = new System.Drawing.Point(176, 61);
            this.namaBelakangTxt.Name = "namaBelakangTxt";
            this.namaBelakangTxt.Size = new System.Drawing.Size(100, 20);
            this.namaBelakangTxt.TabIndex = 3;
            // 
            // nama_belakang
            // 
            this.nama_belakang.AutoSize = true;
            this.nama_belakang.Location = new System.Drawing.Point(173, 34);
            this.nama_belakang.Name = "nama_belakang";
            this.nama_belakang.Size = new System.Drawing.Size(83, 13);
            this.nama_belakang.TabIndex = 2;
            this.nama_belakang.Text = "Nama Belakang";
            // 
            // namaDepanTxt
            // 
            this.namaDepanTxt.Location = new System.Drawing.Point(35, 61);
            this.namaDepanTxt.Name = "namaDepanTxt";
            this.namaDepanTxt.Size = new System.Drawing.Size(100, 20);
            this.namaDepanTxt.TabIndex = 1;
            // 
            // nama_depan
            // 
            this.nama_depan.AutoSize = true;
            this.nama_depan.Location = new System.Drawing.Point(32, 34);
            this.nama_depan.Name = "nama_depan";
            this.nama_depan.Size = new System.Drawing.Size(70, 13);
            this.nama_depan.TabIndex = 0;
            this.nama_depan.Text = "Nama Depan";
            // 
            // Pasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 669);
            this.Controls.Add(this.patientpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pasien";
            this.Text = "Form3";
            this.patientpanel.ResumeLayout(false);
            this.patientpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel patientpanel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox patient_comboBox_jenisKelamin;
        private System.Windows.Forms.Button patient_btn_deleteAll;
        private System.Windows.Forms.Button patient_btn_show;
        private System.Windows.Forms.ListView lvwPatient;
        private System.Windows.Forms.Button patient_btn_delete;
        private System.Windows.Forms.Button patient_btn_update;
        private System.Windows.Forms.Button patient_btn_reset;
        private System.Windows.Forms.Button btn_add_patient;
        private System.Windows.Forms.TextBox alamatTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox noTeleponTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_tanggal_lahir;
        private System.Windows.Forms.TextBox namaBelakangTxt;
        private System.Windows.Forms.Label nama_belakang;
        private System.Windows.Forms.TextBox namaDepanTxt;
        private System.Windows.Forms.Label nama_depan;
        private System.Windows.Forms.ComboBox asuransiBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cariPasien;
    }
}
namespace Healthcare_Management_System.Forms
{
    partial class UpdatePasien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.asuransiBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.patient_comboBox_jenisKelamin = new System.Windows.Forms.ComboBox();
            this.alamatTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.noTeleponTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_tanggal_lahir = new System.Windows.Forms.Label();
            this.namaBelakangTxt = new System.Windows.Forms.TextBox();
            this.nama_belakang = new System.Windows.Forms.Label();
            this.namaDepanTxt = new System.Windows.Forms.TextBox();
            this.nama_depan = new System.Windows.Forms.Label();
            this.patient_btn_update = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update this patient";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 39;
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
            this.asuransiBox.Location = new System.Drawing.Point(369, 173);
            this.asuransiBox.Name = "asuransiBox";
            this.asuransiBox.Size = new System.Drawing.Size(191, 21);
            this.asuransiBox.TabIndex = 38;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 173);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 20);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // patient_comboBox_jenisKelamin
            // 
            this.patient_comboBox_jenisKelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patient_comboBox_jenisKelamin.FormattingEnabled = true;
            this.patient_comboBox_jenisKelamin.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.patient_comboBox_jenisKelamin.Location = new System.Drawing.Point(200, 172);
            this.patient_comboBox_jenisKelamin.Name = "patient_comboBox_jenisKelamin";
            this.patient_comboBox_jenisKelamin.Size = new System.Drawing.Size(124, 21);
            this.patient_comboBox_jenisKelamin.TabIndex = 36;
            // 
            // alamatTxt
            // 
            this.alamatTxt.Location = new System.Drawing.Point(500, 95);
            this.alamatTxt.Name = "alamatTxt";
            this.alamatTxt.Size = new System.Drawing.Size(159, 20);
            this.alamatTxt.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Jenis Kelamin";
            // 
            // noTeleponTxt
            // 
            this.noTeleponTxt.Location = new System.Drawing.Point(369, 95);
            this.noTeleponTxt.Name = "noTeleponTxt";
            this.noTeleponTxt.Size = new System.Drawing.Size(100, 20);
            this.noTeleponTxt.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Nomor Telepon";
            // 
            // label_tanggal_lahir
            // 
            this.label_tanggal_lahir.AutoSize = true;
            this.label_tanggal_lahir.Location = new System.Drawing.Point(24, 145);
            this.label_tanggal_lahir.Name = "label_tanggal_lahir";
            this.label_tanggal_lahir.Size = new System.Drawing.Size(72, 13);
            this.label_tanggal_lahir.TabIndex = 30;
            this.label_tanggal_lahir.Text = "Tanggal Lahir";
            // 
            // namaBelakangTxt
            // 
            this.namaBelakangTxt.Location = new System.Drawing.Point(200, 95);
            this.namaBelakangTxt.Name = "namaBelakangTxt";
            this.namaBelakangTxt.Size = new System.Drawing.Size(124, 20);
            this.namaBelakangTxt.TabIndex = 29;
            // 
            // nama_belakang
            // 
            this.nama_belakang.AutoSize = true;
            this.nama_belakang.Location = new System.Drawing.Point(197, 68);
            this.nama_belakang.Name = "nama_belakang";
            this.nama_belakang.Size = new System.Drawing.Size(83, 13);
            this.nama_belakang.TabIndex = 28;
            this.nama_belakang.Text = "Nama Belakang";
            // 
            // namaDepanTxt
            // 
            this.namaDepanTxt.Location = new System.Drawing.Point(27, 95);
            this.namaDepanTxt.Name = "namaDepanTxt";
            this.namaDepanTxt.Size = new System.Drawing.Size(125, 20);
            this.namaDepanTxt.TabIndex = 27;
            // 
            // nama_depan
            // 
            this.nama_depan.AutoSize = true;
            this.nama_depan.Location = new System.Drawing.Point(24, 68);
            this.nama_depan.Name = "nama_depan";
            this.nama_depan.Size = new System.Drawing.Size(70, 13);
            this.nama_depan.TabIndex = 26;
            this.nama_depan.Text = "Nama Depan";
            // 
            // patient_btn_update
            // 
            this.patient_btn_update.Location = new System.Drawing.Point(480, 233);
            this.patient_btn_update.Name = "patient_btn_update";
            this.patient_btn_update.Size = new System.Drawing.Size(78, 32);
            this.patient_btn_update.TabIndex = 40;
            this.patient_btn_update.Text = "Update";
            this.patient_btn_update.UseVisualStyleBackColor = true;
            this.patient_btn_update.Click += new System.EventHandler(this.patient_btn_update_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(581, 233);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(78, 32);
            this.cancelBtn.TabIndex = 41;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // UpdatePasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 284);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.patient_btn_update);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.asuransiBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.patient_comboBox_jenisKelamin);
            this.Controls.Add(this.alamatTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.noTeleponTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_tanggal_lahir);
            this.Controls.Add(this.namaBelakangTxt);
            this.Controls.Add(this.nama_belakang);
            this.Controls.Add(this.namaDepanTxt);
            this.Controls.Add(this.nama_depan);
            this.Controls.Add(this.label1);
            this.Name = "UpdatePasien";
            this.Text = "Update Data Pasien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox asuransiBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox patient_comboBox_jenisKelamin;
        private System.Windows.Forms.TextBox alamatTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox noTeleponTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_tanggal_lahir;
        private System.Windows.Forms.TextBox namaBelakangTxt;
        private System.Windows.Forms.Label nama_belakang;
        private System.Windows.Forms.TextBox namaDepanTxt;
        private System.Windows.Forms.Label nama_depan;
        private System.Windows.Forms.Button patient_btn_update;
        private System.Windows.Forms.Button cancelBtn;
    }
}
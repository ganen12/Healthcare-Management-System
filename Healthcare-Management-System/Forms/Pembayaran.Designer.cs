namespace Healthcare_Management_System
{
    partial class pembayaranPage
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
            this.belumBayar = new System.Windows.Forms.RadioButton();
            this.sudahBayar = new System.Windows.Forms.RadioButton();
            this.lavel = new System.Windows.Forms.Label();
            this.cariPembayaran = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hargaText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pertemuanBox = new System.Windows.Forms.ComboBox();
            this.nama_belakang = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.namaPasien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.patient_btn_deleteAll = new System.Windows.Forms.Button();
            this.patient_btn_show = new System.Windows.Forms.Button();
            this.lvwPembayaran = new System.Windows.Forms.ListView();
            this.patient_btn_delete = new System.Windows.Forms.Button();
            this.patient_btn_update = new System.Windows.Forms.Button();
            this.patient_btn_reset = new System.Windows.Forms.Button();
            this.btn_add_patient = new System.Windows.Forms.Button();
            this.patientpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientpanel
            // 
            this.patientpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientpanel.Controls.Add(this.belumBayar);
            this.patientpanel.Controls.Add(this.sudahBayar);
            this.patientpanel.Controls.Add(this.lavel);
            this.patientpanel.Controls.Add(this.cariPembayaran);
            this.patientpanel.Controls.Add(this.infoLabel);
            this.patientpanel.Controls.Add(this.label1);
            this.patientpanel.Controls.Add(this.hargaText);
            this.patientpanel.Controls.Add(this.label3);
            this.patientpanel.Controls.Add(this.pertemuanBox);
            this.patientpanel.Controls.Add(this.nama_belakang);
            this.patientpanel.Controls.Add(this.listView1);
            this.patientpanel.Controls.Add(this.namaPasien);
            this.patientpanel.Controls.Add(this.label4);
            this.patientpanel.Controls.Add(this.patient_btn_deleteAll);
            this.patientpanel.Controls.Add(this.patient_btn_show);
            this.patientpanel.Controls.Add(this.lvwPembayaran);
            this.patientpanel.Controls.Add(this.patient_btn_delete);
            this.patientpanel.Controls.Add(this.patient_btn_update);
            this.patientpanel.Controls.Add(this.patient_btn_reset);
            this.patientpanel.Controls.Add(this.btn_add_patient);
            this.patientpanel.Location = new System.Drawing.Point(6, 44);
            this.patientpanel.Name = "patientpanel";
            this.patientpanel.Size = new System.Drawing.Size(831, 593);
            this.patientpanel.TabIndex = 26;
            // 
            // belumBayar
            // 
            this.belumBayar.AutoSize = true;
            this.belumBayar.Location = new System.Drawing.Point(673, 60);
            this.belumBayar.Name = "belumBayar";
            this.belumBayar.Size = new System.Drawing.Size(84, 17);
            this.belumBayar.TabIndex = 45;
            this.belumBayar.TabStop = true;
            this.belumBayar.Text = "Belum Bayar";
            this.belumBayar.UseVisualStyleBackColor = true;
            this.belumBayar.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // sudahBayar
            // 
            this.sudahBayar.AutoSize = true;
            this.sudahBayar.Location = new System.Drawing.Point(570, 60);
            this.sudahBayar.Name = "sudahBayar";
            this.sudahBayar.Size = new System.Drawing.Size(86, 17);
            this.sudahBayar.TabIndex = 44;
            this.sudahBayar.TabStop = true;
            this.sudahBayar.Text = "Sudah Bayar";
            this.sudahBayar.UseVisualStyleBackColor = true;
            this.sudahBayar.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // lavel
            // 
            this.lavel.AutoSize = true;
            this.lavel.Location = new System.Drawing.Point(587, 187);
            this.lavel.Name = "lavel";
            this.lavel.Size = new System.Drawing.Size(87, 13);
            this.lavel.TabIndex = 41;
            this.lavel.Text = "Cari Pembayaran";
            // 
            // cariPembayaran
            // 
            this.cariPembayaran.Location = new System.Drawing.Point(590, 212);
            this.cariPembayaran.Name = "cariPembayaran";
            this.cariPembayaran.Size = new System.Drawing.Size(179, 20);
            this.cariPembayaran.TabIndex = 40;
            this.cariPembayaran.TextChanged += new System.EventHandler(this.cariPembayaran_TextChanged);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(307, 88);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(29, 12);
            this.infoLabel.TabIndex = 39;
            this.infoLabel.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(565, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Status Pembayaran";
            // 
            // hargaText
            // 
            this.hargaText.Location = new System.Drawing.Point(307, 164);
            this.hargaText.Name = "hargaText";
            this.hargaText.Size = new System.Drawing.Size(119, 20);
            this.hargaText.TabIndex = 36;
            this.hargaText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Harga";
            // 
            // pertemuanBox
            // 
            this.pertemuanBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pertemuanBox.FormattingEnabled = true;
            this.pertemuanBox.Location = new System.Drawing.Point(307, 60);
            this.pertemuanBox.Name = "pertemuanBox";
            this.pertemuanBox.Size = new System.Drawing.Size(231, 21);
            this.pertemuanBox.TabIndex = 34;
            // 
            // nama_belakang
            // 
            this.nama_belakang.AutoSize = true;
            this.nama_belakang.Location = new System.Drawing.Point(304, 33);
            this.nama_belakang.Name = "nama_belakang";
            this.nama_belakang.Size = new System.Drawing.Size(58, 13);
            this.nama_belakang.TabIndex = 33;
            this.nama_belakang.Text = "Pertemuan";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(35, 87);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(231, 97);
            this.listView1.TabIndex = 30;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // namaPasien
            // 
            this.namaPasien.Location = new System.Drawing.Point(35, 61);
            this.namaPasien.Name = "namaPasien";
            this.namaPasien.Size = new System.Drawing.Size(231, 20);
            this.namaPasien.TabIndex = 29;
            this.namaPasien.TextChanged += new System.EventHandler(this.namaPasien_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Pasien";
            // 
            // patient_btn_deleteAll
            // 
            this.patient_btn_deleteAll.BackColor = System.Drawing.Color.Tomato;
            this.patient_btn_deleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patient_btn_deleteAll.Location = new System.Drawing.Point(691, 473);
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
            // lvwPembayaran
            // 
            this.lvwPembayaran.HideSelection = false;
            this.lvwPembayaran.Location = new System.Drawing.Point(35, 250);
            this.lvwPembayaran.Name = "lvwPembayaran";
            this.lvwPembayaran.Size = new System.Drawing.Size(734, 196);
            this.lvwPembayaran.TabIndex = 18;
            this.lvwPembayaran.UseCompatibleStateImageBehavior = false;
            // 
            // patient_btn_delete
            // 
            this.patient_btn_delete.BackColor = System.Drawing.Color.Tomato;
            this.patient_btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patient_btn_delete.Location = new System.Drawing.Point(596, 473);
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
            this.patient_btn_update.Location = new System.Drawing.Point(500, 473);
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
            this.btn_add_patient.Location = new System.Drawing.Point(35, 205);
            this.btn_add_patient.Name = "btn_add_patient";
            this.btn_add_patient.Size = new System.Drawing.Size(78, 32);
            this.btn_add_patient.TabIndex = 13;
            this.btn_add_patient.Text = "Add";
            this.btn_add_patient.UseVisualStyleBackColor = false;
            this.btn_add_patient.Click += new System.EventHandler(this.btn_add_patient_Click);
            // 
            // pembayaranPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 681);
            this.Controls.Add(this.patientpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pembayaranPage";
            this.Text = "Pembayaran";
            this.patientpanel.ResumeLayout(false);
            this.patientpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel patientpanel;
        private System.Windows.Forms.Button patient_btn_deleteAll;
        private System.Windows.Forms.Button patient_btn_show;
        private System.Windows.Forms.ListView lvwPembayaran;
        private System.Windows.Forms.Button patient_btn_delete;
        private System.Windows.Forms.Button patient_btn_update;
        private System.Windows.Forms.Button patient_btn_reset;
        private System.Windows.Forms.Button btn_add_patient;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox namaPasien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox pertemuanBox;
        private System.Windows.Forms.Label nama_belakang;
        private System.Windows.Forms.TextBox hargaText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label lavel;
        private System.Windows.Forms.TextBox cariPembayaran;
        private System.Windows.Forms.RadioButton belumBayar;
        private System.Windows.Forms.RadioButton sudahBayar;
    }
}
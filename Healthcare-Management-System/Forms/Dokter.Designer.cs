namespace Healthcare_Management_System
{
    partial class dokterPage
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
            this.dokterPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cariDokter = new System.Windows.Forms.TextBox();
            this.btn_add_jadwal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.spesialisasiBox = new System.Windows.Forms.ComboBox();
            this.btn_deleteAll = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.lvwDoctor = new System.Windows.Forms.ListView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.namaBelakang = new System.Windows.Forms.TextBox();
            this.nama_belakang = new System.Windows.Forms.Label();
            this.namaDepan = new System.Windows.Forms.TextBox();
            this.nama_depan = new System.Windows.Forms.Label();
            this.dokterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dokterPanel
            // 
            this.dokterPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dokterPanel.Controls.Add(this.label5);
            this.dokterPanel.Controls.Add(this.cariDokter);
            this.dokterPanel.Controls.Add(this.btn_add_jadwal);
            this.dokterPanel.Controls.Add(this.label6);
            this.dokterPanel.Controls.Add(this.spesialisasiBox);
            this.dokterPanel.Controls.Add(this.btn_deleteAll);
            this.dokterPanel.Controls.Add(this.btn_show);
            this.dokterPanel.Controls.Add(this.lvwDoctor);
            this.dokterPanel.Controls.Add(this.btn_delete);
            this.dokterPanel.Controls.Add(this.btn_update);
            this.dokterPanel.Controls.Add(this.btn_reset);
            this.dokterPanel.Controls.Add(this.btn_add);
            this.dokterPanel.Controls.Add(this.label1);
            this.dokterPanel.Controls.Add(this.namaBelakang);
            this.dokterPanel.Controls.Add(this.nama_belakang);
            this.dokterPanel.Controls.Add(this.namaDepan);
            this.dokterPanel.Controls.Add(this.nama_depan);
            this.dokterPanel.Location = new System.Drawing.Point(125, 33);
            this.dokterPanel.Name = "dokterPanel";
            this.dokterPanel.Size = new System.Drawing.Size(831, 607);
            this.dokterPanel.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(587, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Cari Dokter";
            // 
            // cariDokter
            // 
            this.cariDokter.Location = new System.Drawing.Point(590, 217);
            this.cariDokter.Name = "cariDokter";
            this.cariDokter.Size = new System.Drawing.Size(179, 20);
            this.cariDokter.TabIndex = 34;
            this.cariDokter.TextChanged += new System.EventHandler(this.cariDoctor_TextChanged);
            // 
            // btn_add_jadwal
            // 
            this.btn_add_jadwal.Location = new System.Drawing.Point(451, 64);
            this.btn_add_jadwal.Name = "btn_add_jadwal";
            this.btn_add_jadwal.Size = new System.Drawing.Size(78, 32);
            this.btn_add_jadwal.TabIndex = 33;
            this.btn_add_jadwal.Text = "Add Jadwal";
            this.btn_add_jadwal.UseVisualStyleBackColor = true;
            this.btn_add_jadwal.Click += new System.EventHandler(this.btn_add_jadwal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(428, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 31;
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
            this.spesialisasiBox.Location = new System.Drawing.Point(37, 149);
            this.spesialisasiBox.Name = "spesialisasiBox";
            this.spesialisasiBox.Size = new System.Drawing.Size(182, 21);
            this.spesialisasiBox.TabIndex = 24;
            // 
            // btn_deleteAll
            // 
            this.btn_deleteAll.BackColor = System.Drawing.Color.Tomato;
            this.btn_deleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteAll.Location = new System.Drawing.Point(691, 473);
            this.btn_deleteAll.Name = "btn_deleteAll";
            this.btn_deleteAll.Size = new System.Drawing.Size(78, 32);
            this.btn_deleteAll.TabIndex = 20;
            this.btn_deleteAll.Text = "Delete All";
            this.btn_deleteAll.UseVisualStyleBackColor = false;
            this.btn_deleteAll.Click += new System.EventHandler(this.btn_deleteAll_Click);
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.Wheat;
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show.Location = new System.Drawing.Point(35, 473);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(78, 32);
            this.btn_show.TabIndex = 19;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // lvwDoctor
            // 
            this.lvwDoctor.HideSelection = false;
            this.lvwDoctor.Location = new System.Drawing.Point(35, 250);
            this.lvwDoctor.Name = "lvwDoctor";
            this.lvwDoctor.Size = new System.Drawing.Size(734, 196);
            this.lvwDoctor.TabIndex = 18;
            this.lvwDoctor.UseCompatibleStateImageBehavior = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Tomato;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(590, 473);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(78, 32);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Wheat;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Location = new System.Drawing.Point(489, 473);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(78, 32);
            this.btn_update.TabIndex = 16;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Honeydew;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Location = new System.Drawing.Point(141, 205);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(78, 32);
            this.btn_reset.TabIndex = 15;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.LightGreen;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Location = new System.Drawing.Point(35, 205);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(78, 32);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Spesialisasi";
            // 
            // namaBelakang
            // 
            this.namaBelakang.Location = new System.Drawing.Point(207, 76);
            this.namaBelakang.Name = "namaBelakang";
            this.namaBelakang.Size = new System.Drawing.Size(145, 20);
            this.namaBelakang.TabIndex = 3;
            // 
            // nama_belakang
            // 
            this.nama_belakang.AutoSize = true;
            this.nama_belakang.Location = new System.Drawing.Point(204, 49);
            this.nama_belakang.Name = "nama_belakang";
            this.nama_belakang.Size = new System.Drawing.Size(83, 13);
            this.nama_belakang.TabIndex = 2;
            this.nama_belakang.Text = "Nama Belakang";
            // 
            // namaDepan
            // 
            this.namaDepan.Location = new System.Drawing.Point(35, 76);
            this.namaDepan.Name = "namaDepan";
            this.namaDepan.Size = new System.Drawing.Size(145, 20);
            this.namaDepan.TabIndex = 1;
            // 
            // nama_depan
            // 
            this.nama_depan.AutoSize = true;
            this.nama_depan.Location = new System.Drawing.Point(32, 49);
            this.nama_depan.Name = "nama_depan";
            this.nama_depan.Size = new System.Drawing.Size(70, 13);
            this.nama_depan.TabIndex = 0;
            this.nama_depan.Text = "Nama Depan";
            // 
            // dokterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 672);
            this.Controls.Add(this.dokterPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dokterPage";
            this.Text = "Dokter";
            this.dokterPanel.ResumeLayout(false);
            this.dokterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dokterPanel;
        private System.Windows.Forms.Button btn_deleteAll;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.ListView lvwDoctor;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namaBelakang;
        private System.Windows.Forms.Label nama_belakang;
        private System.Windows.Forms.TextBox namaDepan;
        private System.Windows.Forms.Label nama_depan;
        private System.Windows.Forms.ComboBox spesialisasiBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_add_jadwal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cariDokter;
    }
}
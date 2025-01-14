namespace Healthcare_Management_System
{
    partial class Catatan_Medis
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
            this.lavel = new System.Windows.Forms.Label();
            this.cariCatatanMedis = new System.Windows.Forms.TextBox();
            this.obatBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.perawatanBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pertemuanBox = new System.Windows.Forms.ComboBox();
            this.nama_belakang = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.namaPasien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_deleteAll = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.lvwCatatan = new System.Windows.Forms.ListView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.patient_btn_update = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.diagnosisBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.patientpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientpanel
            // 
            this.patientpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientpanel.Controls.Add(this.lavel);
            this.patientpanel.Controls.Add(this.cariCatatanMedis);
            this.patientpanel.Controls.Add(this.obatBox);
            this.patientpanel.Controls.Add(this.label2);
            this.patientpanel.Controls.Add(this.infoLabel);
            this.patientpanel.Controls.Add(this.perawatanBox);
            this.patientpanel.Controls.Add(this.label1);
            this.patientpanel.Controls.Add(this.pertemuanBox);
            this.patientpanel.Controls.Add(this.nama_belakang);
            this.patientpanel.Controls.Add(this.listView1);
            this.patientpanel.Controls.Add(this.namaPasien);
            this.patientpanel.Controls.Add(this.label4);
            this.patientpanel.Controls.Add(this.btn_deleteAll);
            this.patientpanel.Controls.Add(this.btn_show);
            this.patientpanel.Controls.Add(this.lvwCatatan);
            this.patientpanel.Controls.Add(this.btn_delete);
            this.patientpanel.Controls.Add(this.patient_btn_update);
            this.patientpanel.Controls.Add(this.btn_reset);
            this.patientpanel.Controls.Add(this.btn_add);
            this.patientpanel.Controls.Add(this.diagnosisBox);
            this.patientpanel.Controls.Add(this.label3);
            this.patientpanel.Location = new System.Drawing.Point(14, 32);
            this.patientpanel.Name = "patientpanel";
            this.patientpanel.Size = new System.Drawing.Size(831, 607);
            this.patientpanel.TabIndex = 26;
            // 
            // lavel
            // 
            this.lavel.AutoSize = true;
            this.lavel.Location = new System.Drawing.Point(586, 228);
            this.lavel.Name = "lavel";
            this.lavel.Size = new System.Drawing.Size(96, 13);
            this.lavel.TabIndex = 44;
            this.lavel.Text = "Cari Catatan Medis";
            // 
            // cariCatatanMedis
            // 
            this.cariCatatanMedis.Location = new System.Drawing.Point(589, 253);
            this.cariCatatanMedis.Name = "cariCatatanMedis";
            this.cariCatatanMedis.Size = new System.Drawing.Size(179, 20);
            this.cariCatatanMedis.TabIndex = 43;
            this.cariCatatanMedis.TextChanged += new System.EventHandler(this.cariCatatanMedis_TextChanged);
            // 
            // obatBox
            // 
            this.obatBox.Location = new System.Drawing.Point(556, 141);
            this.obatBox.Name = "obatBox";
            this.obatBox.Size = new System.Drawing.Size(213, 20);
            this.obatBox.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Obat";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(292, 85);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(29, 12);
            this.infoLabel.TabIndex = 40;
            this.infoLabel.Text = "label2";
            // 
            // perawatanBox
            // 
            this.perawatanBox.Location = new System.Drawing.Point(294, 141);
            this.perawatanBox.Name = "perawatanBox";
            this.perawatanBox.Size = new System.Drawing.Size(231, 20);
            this.perawatanBox.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Perawatan";
            // 
            // pertemuanBox
            // 
            this.pertemuanBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pertemuanBox.FormattingEnabled = true;
            this.pertemuanBox.Location = new System.Drawing.Point(294, 59);
            this.pertemuanBox.Name = "pertemuanBox";
            this.pertemuanBox.Size = new System.Drawing.Size(231, 21);
            this.pertemuanBox.TabIndex = 32;
            // 
            // nama_belakang
            // 
            this.nama_belakang.AutoSize = true;
            this.nama_belakang.Location = new System.Drawing.Point(291, 32);
            this.nama_belakang.Name = "nama_belakang";
            this.nama_belakang.Size = new System.Drawing.Size(58, 13);
            this.nama_belakang.TabIndex = 31;
            this.nama_belakang.Text = "Pertemuan";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(35, 85);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(231, 97);
            this.listView1.TabIndex = 30;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // namaPasien
            // 
            this.namaPasien.Location = new System.Drawing.Point(35, 59);
            this.namaPasien.Name = "namaPasien";
            this.namaPasien.Size = new System.Drawing.Size(231, 20);
            this.namaPasien.TabIndex = 29;
            this.namaPasien.TextChanged += new System.EventHandler(this.namaPasien_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Pasien";
            // 
            // btn_deleteAll
            // 
            this.btn_deleteAll.BackColor = System.Drawing.Color.Tomato;
            this.btn_deleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteAll.Location = new System.Drawing.Point(690, 509);
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
            this.btn_show.Location = new System.Drawing.Point(34, 509);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(78, 32);
            this.btn_show.TabIndex = 19;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // lvwCatatan
            // 
            this.lvwCatatan.HideSelection = false;
            this.lvwCatatan.Location = new System.Drawing.Point(34, 286);
            this.lvwCatatan.Name = "lvwCatatan";
            this.lvwCatatan.Size = new System.Drawing.Size(734, 196);
            this.lvwCatatan.TabIndex = 18;
            this.lvwCatatan.UseCompatibleStateImageBehavior = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Tomato;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(589, 509);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(78, 32);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // patient_btn_update
            // 
            this.patient_btn_update.BackColor = System.Drawing.Color.Wheat;
            this.patient_btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patient_btn_update.Location = new System.Drawing.Point(490, 509);
            this.patient_btn_update.Name = "patient_btn_update";
            this.patient_btn_update.Size = new System.Drawing.Size(78, 32);
            this.patient_btn_update.TabIndex = 16;
            this.patient_btn_update.Text = "Update";
            this.patient_btn_update.UseVisualStyleBackColor = false;
            this.patient_btn_update.Click += new System.EventHandler(this.patient_btn_update_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Honeydew;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Location = new System.Drawing.Point(140, 241);
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
            this.btn_add.Location = new System.Drawing.Point(34, 241);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(78, 32);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // diagnosisBox
            // 
            this.diagnosisBox.Location = new System.Drawing.Point(556, 59);
            this.diagnosisBox.Name = "diagnosisBox";
            this.diagnosisBox.Size = new System.Drawing.Size(213, 20);
            this.diagnosisBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Diagnosis";
            // 
            // Catatan_Medis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 675);
            this.Controls.Add(this.patientpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Catatan_Medis";
            this.Text = "Catatan_Medis";
            this.patientpanel.ResumeLayout(false);
            this.patientpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel patientpanel;
        private System.Windows.Forms.Button btn_deleteAll;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.ListView lvwCatatan;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button patient_btn_update;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox diagnosisBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox namaPasien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox perawatanBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pertemuanBox;
        private System.Windows.Forms.Label nama_belakang;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TextBox obatBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lavel;
        private System.Windows.Forms.TextBox cariCatatanMedis;
    }
}
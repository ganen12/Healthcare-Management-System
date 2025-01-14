namespace Healthcare_Management_System
{
    partial class pertemuanPage
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
            this.btn_deleteAll = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.lvwPertemuan = new System.Windows.Forms.ListView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.nama_belakang = new System.Windows.Forms.Label();
            this.namaPasien = new System.Windows.Forms.TextBox();
            this.nama_depan = new System.Windows.Forms.Label();
            this.dokterPanel = new System.Windows.Forms.Panel();
            this.lavel = new System.Windows.Forms.Label();
            this.cariPertemuan = new System.Windows.Forms.TextBox();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.koleksiDokter = new System.Windows.Forms.ComboBox();
            this.dokterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_deleteAll
            // 
            this.btn_deleteAll.BackColor = System.Drawing.Color.Tomato;
            this.btn_deleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteAll.Location = new System.Drawing.Point(722, 473);
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
            // lvwPertemuan
            // 
            this.lvwPertemuan.HideSelection = false;
            this.lvwPertemuan.Location = new System.Drawing.Point(35, 250);
            this.lvwPertemuan.Name = "lvwPertemuan";
            this.lvwPertemuan.Size = new System.Drawing.Size(765, 196);
            this.lvwPertemuan.TabIndex = 18;
            this.lvwPertemuan.UseCompatibleStateImageBehavior = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Tomato;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(621, 473);
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
            this.btn_update.Location = new System.Drawing.Point(522, 473);
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
            // nama_belakang
            // 
            this.nama_belakang.AutoSize = true;
            this.nama_belakang.Location = new System.Drawing.Point(291, 34);
            this.nama_belakang.Name = "nama_belakang";
            this.nama_belakang.Size = new System.Drawing.Size(39, 13);
            this.nama_belakang.TabIndex = 2;
            this.nama_belakang.Text = "Dokter";
            // 
            // namaPasien
            // 
            this.namaPasien.Location = new System.Drawing.Point(35, 61);
            this.namaPasien.Name = "namaPasien";
            this.namaPasien.Size = new System.Drawing.Size(231, 20);
            this.namaPasien.TabIndex = 1;
            this.namaPasien.TextChanged += new System.EventHandler(this.namaPasien_TextChanged);
            // 
            // nama_depan
            // 
            this.nama_depan.AutoSize = true;
            this.nama_depan.Location = new System.Drawing.Point(32, 34);
            this.nama_depan.Name = "nama_depan";
            this.nama_depan.Size = new System.Drawing.Size(39, 13);
            this.nama_depan.TabIndex = 0;
            this.nama_depan.Text = "Pasien";
            // 
            // dokterPanel
            // 
            this.dokterPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dokterPanel.Controls.Add(this.lavel);
            this.dokterPanel.Controls.Add(this.cariPertemuan);
            this.dokterPanel.Controls.Add(this.statusBox);
            this.dokterPanel.Controls.Add(this.label1);
            this.dokterPanel.Controls.Add(this.dateTimePicker2);
            this.dokterPanel.Controls.Add(this.dateTimePicker1);
            this.dokterPanel.Controls.Add(this.label2);
            this.dokterPanel.Controls.Add(this.listView1);
            this.dokterPanel.Controls.Add(this.koleksiDokter);
            this.dokterPanel.Controls.Add(this.btn_deleteAll);
            this.dokterPanel.Controls.Add(this.btn_show);
            this.dokterPanel.Controls.Add(this.lvwPertemuan);
            this.dokterPanel.Controls.Add(this.btn_delete);
            this.dokterPanel.Controls.Add(this.btn_update);
            this.dokterPanel.Controls.Add(this.btn_reset);
            this.dokterPanel.Controls.Add(this.btn_add);
            this.dokterPanel.Controls.Add(this.nama_belakang);
            this.dokterPanel.Controls.Add(this.namaPasien);
            this.dokterPanel.Controls.Add(this.nama_depan);
            this.dokterPanel.Location = new System.Drawing.Point(197, 46);
            this.dokterPanel.Name = "dokterPanel";
            this.dokterPanel.Size = new System.Drawing.Size(831, 607);
            this.dokterPanel.TabIndex = 27;
            // 
            // lavel
            // 
            this.lavel.AutoSize = true;
            this.lavel.Location = new System.Drawing.Point(618, 187);
            this.lavel.Name = "lavel";
            this.lavel.Size = new System.Drawing.Size(79, 13);
            this.lavel.TabIndex = 35;
            this.lavel.Text = "Cari Pertemuan";
            // 
            // cariPertemuan
            // 
            this.cariPertemuan.Location = new System.Drawing.Point(621, 212);
            this.cariPertemuan.Name = "cariPertemuan";
            this.cariPertemuan.Size = new System.Drawing.Size(179, 20);
            this.cariPertemuan.TabIndex = 34;
            this.cariPertemuan.TextChanged += new System.EventHandler(this.cariPertemuan_TextChanged);
            // 
            // statusBox
            // 
            this.statusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Sedang Berlangsung",
            "Selesai",
            "Dibatalkan"});
            this.statusBox.Location = new System.Drawing.Point(294, 163);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(182, 21);
            this.statusBox.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Status";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "hh:mm tt";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(662, 62);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(74, 20);
            this.dateTimePicker2.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(513, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tanggal Pertemuan";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(35, 87);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(231, 97);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // koleksiDokter
            // 
            this.koleksiDokter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.koleksiDokter.FormattingEnabled = true;
            this.koleksiDokter.Location = new System.Drawing.Point(294, 61);
            this.koleksiDokter.Name = "koleksiDokter";
            this.koleksiDokter.Size = new System.Drawing.Size(182, 21);
            this.koleksiDokter.TabIndex = 24;
            // 
            // pertemuanPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 699);
            this.Controls.Add(this.dokterPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pertemuanPage";
            this.Text = "Pertemuan";
            this.dokterPanel.ResumeLayout(false);
            this.dokterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_deleteAll;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.ListView lvwPertemuan;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label nama_belakang;
        private System.Windows.Forms.TextBox namaPasien;
        private System.Windows.Forms.Label nama_depan;
        private System.Windows.Forms.Panel dokterPanel;
        private System.Windows.Forms.ComboBox koleksiDokter;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lavel;
        private System.Windows.Forms.TextBox cariPertemuan;
    }
}
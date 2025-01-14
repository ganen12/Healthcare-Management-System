namespace Healthcare_Management_System
{
    partial class Form1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.defaultPanel = new System.Windows.Forms.Panel();
            this.patient_comboBox_jenisKelamin = new System.Windows.Forms.ComboBox();
            this.patient_btn_deleteAll = new System.Windows.Forms.Button();
            this.patient_btn_show = new System.Windows.Forms.Button();
            this.lvwPatient = new System.Windows.Forms.ListView();
            this.patient_btn_delete = new System.Windows.Forms.Button();
            this.patient_btn_update = new System.Windows.Forms.Button();
            this.patient_btn_reset = new System.Windows.Forms.Button();
            this.btn_add_patient = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_tanggal_lahir = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nama_belakang = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nama_depan = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pageTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.defaultPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, -1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(229, 723);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 100);
            this.panel1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(23, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "JogjaHealthcare";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 109);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(223, 46);
            this.button1.TabIndex = 26;
            this.button1.Text = "Pasien";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 161);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(223, 46);
            this.button2.TabIndex = 27;
            this.button2.Text = "Dokter";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 213);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(223, 46);
            this.button3.TabIndex = 28;
            this.button3.Text = "Pertemuan";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 265);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(223, 46);
            this.button4.TabIndex = 29;
            this.button4.Text = "Catatan Medis";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(3, 317);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(223, 46);
            this.button5.TabIndex = 30;
            this.button5.Text = "Pembayaran";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutBtn.BackColor = System.Drawing.Color.Red;
            this.logOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutBtn.FlatAppearance.BorderSize = 0;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.Color.White;
            this.logOutBtn.Location = new System.Drawing.Point(-3, 299);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(0);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(229, 51);
            this.logOutBtn.TabIndex = 31;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(35, 139);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // defaultPanel
            // 
            this.defaultPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultPanel.Controls.Add(this.dateTimePicker1);
            this.defaultPanel.Controls.Add(this.patient_comboBox_jenisKelamin);
            this.defaultPanel.Controls.Add(this.patient_btn_deleteAll);
            this.defaultPanel.Controls.Add(this.patient_btn_show);
            this.defaultPanel.Controls.Add(this.lvwPatient);
            this.defaultPanel.Controls.Add(this.patient_btn_delete);
            this.defaultPanel.Controls.Add(this.patient_btn_update);
            this.defaultPanel.Controls.Add(this.patient_btn_reset);
            this.defaultPanel.Controls.Add(this.btn_add_patient);
            this.defaultPanel.Controls.Add(this.textBox6);
            this.defaultPanel.Controls.Add(this.label3);
            this.defaultPanel.Controls.Add(this.label2);
            this.defaultPanel.Controls.Add(this.textBox4);
            this.defaultPanel.Controls.Add(this.label1);
            this.defaultPanel.Controls.Add(this.label_tanggal_lahir);
            this.defaultPanel.Controls.Add(this.textBox2);
            this.defaultPanel.Controls.Add(this.nama_belakang);
            this.defaultPanel.Controls.Add(this.textBox1);
            this.defaultPanel.Controls.Add(this.nama_depan);
            this.defaultPanel.Location = new System.Drawing.Point(235, 122);
            this.defaultPanel.Name = "defaultPanel";
            this.defaultPanel.Size = new System.Drawing.Size(848, 593);
            this.defaultPanel.TabIndex = 25;
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
            this.patient_btn_deleteAll.Location = new System.Drawing.Point(388, 473);
            this.patient_btn_deleteAll.Name = "patient_btn_deleteAll";
            this.patient_btn_deleteAll.Size = new System.Drawing.Size(78, 32);
            this.patient_btn_deleteAll.TabIndex = 20;
            this.patient_btn_deleteAll.Text = "Delete All";
            this.patient_btn_deleteAll.UseVisualStyleBackColor = true;
            // 
            // patient_btn_show
            // 
            this.patient_btn_show.Location = new System.Drawing.Point(35, 473);
            this.patient_btn_show.Name = "patient_btn_show";
            this.patient_btn_show.Size = new System.Drawing.Size(78, 32);
            this.patient_btn_show.TabIndex = 19;
            this.patient_btn_show.Text = "Show";
            this.patient_btn_show.UseVisualStyleBackColor = true;
            // 
            // lvwPatient
            // 
            this.lvwPatient.HideSelection = false;
            this.lvwPatient.Location = new System.Drawing.Point(35, 250);
            this.lvwPatient.Name = "lvwPatient";
            this.lvwPatient.Size = new System.Drawing.Size(734, 196);
            this.lvwPatient.TabIndex = 18;
            this.lvwPatient.UseCompatibleStateImageBehavior = false;
            // 
            // patient_btn_delete
            // 
            this.patient_btn_delete.Location = new System.Drawing.Point(307, 473);
            this.patient_btn_delete.Name = "patient_btn_delete";
            this.patient_btn_delete.Size = new System.Drawing.Size(78, 32);
            this.patient_btn_delete.TabIndex = 17;
            this.patient_btn_delete.Text = "Delete";
            this.patient_btn_delete.UseVisualStyleBackColor = true;
            // 
            // patient_btn_update
            // 
            this.patient_btn_update.Location = new System.Drawing.Point(226, 473);
            this.patient_btn_update.Name = "patient_btn_update";
            this.patient_btn_update.Size = new System.Drawing.Size(78, 32);
            this.patient_btn_update.TabIndex = 16;
            this.patient_btn_update.Text = "Update";
            this.patient_btn_update.UseVisualStyleBackColor = true;
            this.patient_btn_update.Click += new System.EventHandler(this.patient_btn_update_Click);
            // 
            // patient_btn_reset
            // 
            this.patient_btn_reset.Location = new System.Drawing.Point(141, 205);
            this.patient_btn_reset.Name = "patient_btn_reset";
            this.patient_btn_reset.Size = new System.Drawing.Size(78, 32);
            this.patient_btn_reset.TabIndex = 15;
            this.patient_btn_reset.Text = "Reset";
            this.patient_btn_reset.UseVisualStyleBackColor = true;
            // 
            // btn_add_patient
            // 
            this.btn_add_patient.Location = new System.Drawing.Point(35, 205);
            this.btn_add_patient.Name = "btn_add_patient";
            this.btn_add_patient.Size = new System.Drawing.Size(78, 32);
            this.btn_add_patient.TabIndex = 13;
            this.btn_add_patient.Text = "Add";
            this.btn_add_patient.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(438, 61);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(170, 20);
            this.textBox6.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 34);
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(307, 61);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 34);
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(176, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Wheat;
            this.panel2.Controls.Add(this.pageTitle);
            this.panel2.Location = new System.Drawing.Point(222, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 103);
            this.panel2.TabIndex = 26;
            // 
            // pageTitle
            // 
            this.pageTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pageTitle.AutoSize = true;
            this.pageTitle.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitle.Location = new System.Drawing.Point(442, 37);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(79, 26);
            this.pageTitle.TabIndex = 0;
            this.pageTitle.Text = "Pasien";
            this.pageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.logOutBtn);
            this.panel3.Location = new System.Drawing.Point(3, 366);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 350);
            this.panel3.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1141, 721);
            this.Controls.Add(this.defaultPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.defaultPanel.ResumeLayout(false);
            this.defaultPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel defaultPanel;
        private System.Windows.Forms.ComboBox patient_comboBox_jenisKelamin;
        private System.Windows.Forms.Button patient_btn_deleteAll;
        private System.Windows.Forms.Button patient_btn_show;
        private System.Windows.Forms.ListView lvwPatient;
        private System.Windows.Forms.Button patient_btn_delete;
        private System.Windows.Forms.Button patient_btn_update;
        private System.Windows.Forms.Button patient_btn_reset;
        private System.Windows.Forms.Button btn_add_patient;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_tanggal_lahir;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label nama_belakang;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nama_depan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Panel panel3;
    }
}


namespace Healthcare_Management_System.Forms.Update_Operation
{
    partial class UpdatePertemuan
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
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.koleksiDokter = new System.Windows.Forms.ComboBox();
            this.nama_belakang = new System.Windows.Forms.Label();
            this.namaPasien = new System.Windows.Forms.TextBox();
            this.nama_depan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.appointment_btn_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusBox
            // 
            this.statusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Sedang Berlangsung",
            "Selesai",
            "Dibatalkan"});
            this.statusBox.Location = new System.Drawing.Point(287, 198);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(182, 21);
            this.statusBox.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Status Pertemuan";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "hh:mm tt";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(185, 271);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(74, 20);
            this.dateTimePicker2.TabIndex = 41;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 271);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Tanggal Pertemuan";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(28, 122);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(231, 97);
            this.listView1.TabIndex = 38;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // koleksiDokter
            // 
            this.koleksiDokter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.koleksiDokter.FormattingEnabled = true;
            this.koleksiDokter.Location = new System.Drawing.Point(287, 96);
            this.koleksiDokter.Name = "koleksiDokter";
            this.koleksiDokter.Size = new System.Drawing.Size(182, 21);
            this.koleksiDokter.TabIndex = 37;
            // 
            // nama_belakang
            // 
            this.nama_belakang.AutoSize = true;
            this.nama_belakang.Location = new System.Drawing.Point(284, 69);
            this.nama_belakang.Name = "nama_belakang";
            this.nama_belakang.Size = new System.Drawing.Size(39, 13);
            this.nama_belakang.TabIndex = 36;
            this.nama_belakang.Text = "Dokter";
            // 
            // namaPasien
            // 
            this.namaPasien.Location = new System.Drawing.Point(28, 96);
            this.namaPasien.Name = "namaPasien";
            this.namaPasien.Size = new System.Drawing.Size(231, 20);
            this.namaPasien.TabIndex = 35;
            // 
            // nama_depan
            // 
            this.nama_depan.AutoSize = true;
            this.nama_depan.Location = new System.Drawing.Point(25, 69);
            this.nama_depan.Name = "nama_depan";
            this.nama_depan.Size = new System.Drawing.Size(39, 13);
            this.nama_depan.TabIndex = 34;
            this.nama_depan.Text = "Pasien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 44;
            this.label3.Text = "Update Pertemuan";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(391, 335);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(78, 32);
            this.cancelBtn.TabIndex = 46;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click_1);
            // 
            // appointment_btn_update
            // 
            this.appointment_btn_update.Location = new System.Drawing.Point(290, 335);
            this.appointment_btn_update.Name = "appointment_btn_update";
            this.appointment_btn_update.Size = new System.Drawing.Size(78, 32);
            this.appointment_btn_update.TabIndex = 45;
            this.appointment_btn_update.Text = "Update";
            this.appointment_btn_update.UseVisualStyleBackColor = true;
            this.appointment_btn_update.Click += new System.EventHandler(this.appointment_btn_update_Click_1);
            // 
            // UpdatePertemuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 385);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.appointment_btn_update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.koleksiDokter);
            this.Controls.Add(this.nama_belakang);
            this.Controls.Add(this.namaPasien);
            this.Controls.Add(this.nama_depan);
            this.Name = "UpdatePertemuan";
            this.Text = "UpdatePertemuan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox koleksiDokter;
        private System.Windows.Forms.Label nama_belakang;
        private System.Windows.Forms.TextBox namaPasien;
        private System.Windows.Forms.Label nama_depan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button appointment_btn_update;
    }
}
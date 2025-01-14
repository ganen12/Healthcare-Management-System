namespace Healthcare_Management_System.Forms.Update_Operation
{
    partial class UpdatePembayaran
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
            this.belumBayar = new System.Windows.Forms.RadioButton();
            this.sudahBayar = new System.Windows.Forms.RadioButton();
            this.infoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hargaText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pertemuanBox = new System.Windows.Forms.ComboBox();
            this.nama_belakang = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.namaPasien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.patient_btn_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // belumBayar
            // 
            this.belumBayar.AutoSize = true;
            this.belumBayar.Location = new System.Drawing.Point(139, 240);
            this.belumBayar.Name = "belumBayar";
            this.belumBayar.Size = new System.Drawing.Size(84, 17);
            this.belumBayar.TabIndex = 56;
            this.belumBayar.TabStop = true;
            this.belumBayar.Text = "Belum Bayar";
            this.belumBayar.UseVisualStyleBackColor = true;
            this.belumBayar.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // sudahBayar
            // 
            this.sudahBayar.AutoSize = true;
            this.sudahBayar.Location = new System.Drawing.Point(36, 240);
            this.sudahBayar.Name = "sudahBayar";
            this.sudahBayar.Size = new System.Drawing.Size(86, 17);
            this.sudahBayar.TabIndex = 55;
            this.sudahBayar.TabStop = true;
            this.sudahBayar.Text = "Sudah Bayar";
            this.sudahBayar.UseVisualStyleBackColor = true;
            this.sudahBayar.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(303, 85);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(29, 12);
            this.infoLabel.TabIndex = 54;
            this.infoLabel.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Status Pembayaran";
            // 
            // hargaText
            // 
            this.hargaText.Location = new System.Drawing.Point(303, 161);
            this.hargaText.Name = "hargaText";
            this.hargaText.Size = new System.Drawing.Size(119, 20);
            this.hargaText.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Harga";
            // 
            // pertemuanBox
            // 
            this.pertemuanBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pertemuanBox.FormattingEnabled = true;
            this.pertemuanBox.Location = new System.Drawing.Point(303, 57);
            this.pertemuanBox.Name = "pertemuanBox";
            this.pertemuanBox.Size = new System.Drawing.Size(231, 21);
            this.pertemuanBox.TabIndex = 50;
            // 
            // nama_belakang
            // 
            this.nama_belakang.AutoSize = true;
            this.nama_belakang.Location = new System.Drawing.Point(300, 30);
            this.nama_belakang.Name = "nama_belakang";
            this.nama_belakang.Size = new System.Drawing.Size(58, 13);
            this.nama_belakang.TabIndex = 49;
            this.nama_belakang.Text = "Pertemuan";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(31, 84);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(231, 97);
            this.listView1.TabIndex = 48;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // namaPasien
            // 
            this.namaPasien.Location = new System.Drawing.Point(31, 58);
            this.namaPasien.Name = "namaPasien";
            this.namaPasien.Size = new System.Drawing.Size(231, 20);
            this.namaPasien.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Pasien";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(456, 285);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(78, 32);
            this.cancelBtn.TabIndex = 58;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // patient_btn_update
            // 
            this.patient_btn_update.Location = new System.Drawing.Point(355, 285);
            this.patient_btn_update.Name = "patient_btn_update";
            this.patient_btn_update.Size = new System.Drawing.Size(78, 32);
            this.patient_btn_update.TabIndex = 57;
            this.patient_btn_update.Text = "Update";
            this.patient_btn_update.UseVisualStyleBackColor = true;
            this.patient_btn_update.Click += new System.EventHandler(this.patient_btn_update_Click);
            // 
            // UpdatePembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 338);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.patient_btn_update);
            this.Controls.Add(this.belumBayar);
            this.Controls.Add(this.sudahBayar);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hargaText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pertemuanBox);
            this.Controls.Add(this.nama_belakang);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.namaPasien);
            this.Controls.Add(this.label4);
            this.Name = "UpdatePembayaran";
            this.Text = "UpdatePembayaran";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton belumBayar;
        private System.Windows.Forms.RadioButton sudahBayar;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hargaText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox pertemuanBox;
        private System.Windows.Forms.Label nama_belakang;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox namaPasien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button patient_btn_update;
    }
}
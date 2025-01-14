namespace Healthcare_Management_System.Forms
{
    partial class JadwalDokterForm
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
            this.hariComboBox = new System.Windows.Forms.ComboBox();
            this.shiftComboBox = new System.Windows.Forms.ComboBox();
            this.hariTxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvwDoctor = new System.Windows.Forms.ListView();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.labelNama = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.hariComboBox.Location = new System.Drawing.Point(16, 70);
            this.hariComboBox.Name = "hariComboBox";
            this.hariComboBox.Size = new System.Drawing.Size(121, 21);
            this.hariComboBox.TabIndex = 0;
            // 
            // shiftComboBox
            // 
            this.shiftComboBox.FormattingEnabled = true;
            this.shiftComboBox.Items.AddRange(new object[] {
            "pagi",
            "siang",
            "sore",
            "malam"});
            this.shiftComboBox.Location = new System.Drawing.Point(181, 70);
            this.shiftComboBox.Name = "shiftComboBox";
            this.shiftComboBox.Size = new System.Drawing.Size(121, 21);
            this.shiftComboBox.TabIndex = 1;
            // 
            // hariTxt
            // 
            this.hariTxt.AutoSize = true;
            this.hariTxt.Location = new System.Drawing.Point(13, 45);
            this.hariTxt.Name = "hariTxt";
            this.hariTxt.Size = new System.Drawing.Size(26, 13);
            this.hariTxt.TabIndex = 2;
            this.hariTxt.Text = "Hari";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shift";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(144, 307);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvwDoctor
            // 
            this.lvwDoctor.HideSelection = false;
            this.lvwDoctor.Location = new System.Drawing.Point(16, 109);
            this.lvwDoctor.Name = "lvwDoctor";
            this.lvwDoctor.Size = new System.Drawing.Size(284, 180);
            this.lvwDoctor.TabIndex = 19;
            this.lvwDoctor.UseCompatibleStateImageBehavior = false;
            // 
            // btnSelesai
            // 
            this.btnSelesai.BackColor = System.Drawing.Color.Honeydew;
            this.btnSelesai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelesai.Location = new System.Drawing.Point(225, 307);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(75, 33);
            this.btnSelesai.TabIndex = 20;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = false;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(13, 13);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(50, 16);
            this.labelNama.TabIndex = 21;
            this.labelNama.Text = "label2";
            // 
            // JadwalDokterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 367);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.lvwDoctor);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hariTxt);
            this.Controls.Add(this.shiftComboBox);
            this.Controls.Add(this.hariComboBox);
            this.Name = "JadwalDokterForm";
            this.Text = "JadwalDokterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox hariComboBox;
        private System.Windows.Forms.ComboBox shiftComboBox;
        private System.Windows.Forms.Label hariTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvwDoctor;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Label labelNama;
    }
}
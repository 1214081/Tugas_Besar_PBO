namespace Tugas_Besar_1214081_1214085.view
{
    partial class formInputRokok
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.tbNamaUser = new System.Windows.Forms.TextBox();
            this.cbIDUser = new System.Windows.Forms.ComboBox();
            this.lbJumlah = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.tbJumlahRokok = new System.Windows.Forms.TextBox();
            this.lbMerek = new System.Windows.Forms.Label();
            this.cbMerek = new System.Windows.Forms.ComboBox();
            this.lbHarga = new System.Windows.Forms.Label();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.lbTanggal = new System.Windows.Forms.Label();
            this.btSimpan = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btSimpan);
            this.groupBox.Controls.Add(this.lbTanggal);
            this.groupBox.Controls.Add(this.tbHarga);
            this.groupBox.Controls.Add(this.lbHarga);
            this.groupBox.Controls.Add(this.cbMerek);
            this.groupBox.Controls.Add(this.lbMerek);
            this.groupBox.Controls.Add(this.tbJumlahRokok);
            this.groupBox.Controls.Add(this.lbUser);
            this.groupBox.Controls.Add(this.lbJumlah);
            this.groupBox.Controls.Add(this.cbIDUser);
            this.groupBox.Controls.Add(this.tbNamaUser);
            this.groupBox.Controls.Add(this.dtpTanggal);
            this.groupBox.Location = new System.Drawing.Point(13, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(381, 249);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Input Data Rokok";
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Location = new System.Drawing.Point(143, 181);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(232, 20);
            this.dtpTanggal.TabIndex = 0;
            // 
            // tbNamaUser
            // 
            this.tbNamaUser.Location = new System.Drawing.Point(216, 28);
            this.tbNamaUser.Name = "tbNamaUser";
            this.tbNamaUser.Size = new System.Drawing.Size(159, 20);
            this.tbNamaUser.TabIndex = 1;
            // 
            // cbIDUser
            // 
            this.cbIDUser.FormattingEnabled = true;
            this.cbIDUser.Location = new System.Drawing.Point(143, 27);
            this.cbIDUser.Name = "cbIDUser";
            this.cbIDUser.Size = new System.Drawing.Size(67, 21);
            this.cbIDUser.TabIndex = 2;
            // 
            // lbJumlah
            // 
            this.lbJumlah.AutoSize = true;
            this.lbJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJumlah.Location = new System.Drawing.Point(6, 68);
            this.lbJumlah.Name = "lbJumlah";
            this.lbJumlah.Size = new System.Drawing.Size(131, 18);
            this.lbJumlah.TabIndex = 3;
            this.lbJumlah.Text = "Jumlah (Batang)";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(6, 30);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(44, 18);
            this.lbUser.TabIndex = 4;
            this.lbUser.Text = "User";
            // 
            // tbJumlahRokok
            // 
            this.tbJumlahRokok.Location = new System.Drawing.Point(143, 66);
            this.tbJumlahRokok.Name = "tbJumlahRokok";
            this.tbJumlahRokok.Size = new System.Drawing.Size(232, 20);
            this.tbJumlahRokok.TabIndex = 5;
            // 
            // lbMerek
            // 
            this.lbMerek.AutoSize = true;
            this.lbMerek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMerek.Location = new System.Drawing.Point(6, 107);
            this.lbMerek.Name = "lbMerek";
            this.lbMerek.Size = new System.Drawing.Size(55, 18);
            this.lbMerek.TabIndex = 6;
            this.lbMerek.Text = "Merek";
            // 
            // cbMerek
            // 
            this.cbMerek.FormattingEnabled = true;
            this.cbMerek.Location = new System.Drawing.Point(143, 104);
            this.cbMerek.Name = "cbMerek";
            this.cbMerek.Size = new System.Drawing.Size(232, 21);
            this.cbMerek.TabIndex = 7;
            // 
            // lbHarga
            // 
            this.lbHarga.AutoSize = true;
            this.lbHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHarga.Location = new System.Drawing.Point(6, 145);
            this.lbHarga.Name = "lbHarga";
            this.lbHarga.Size = new System.Drawing.Size(53, 18);
            this.lbHarga.TabIndex = 8;
            this.lbHarga.Text = "Harga";
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(143, 143);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(232, 20);
            this.tbHarga.TabIndex = 9;
            // 
            // lbTanggal
            // 
            this.lbTanggal.AutoSize = true;
            this.lbTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTanggal.Location = new System.Drawing.Point(6, 183);
            this.lbTanggal.Name = "lbTanggal";
            this.lbTanggal.Size = new System.Drawing.Size(67, 18);
            this.lbTanggal.TabIndex = 10;
            this.lbTanggal.Text = "Tanggal";
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(126, 214);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(129, 23);
            this.btSimpan.TabIndex = 11;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            // 
            // formInputRokok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 274);
            this.Controls.Add(this.groupBox);
            this.Name = "formInputRokok";
            this.Text = "Input Rokok";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox cbIDUser;
        private System.Windows.Forms.TextBox tbNamaUser;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Label lbHarga;
        private System.Windows.Forms.ComboBox cbMerek;
        private System.Windows.Forms.Label lbMerek;
        private System.Windows.Forms.TextBox tbJumlahRokok;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbJumlah;
        private System.Windows.Forms.Label lbTanggal;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.Button btSimpan;
    }
}
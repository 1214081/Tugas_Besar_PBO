namespace Tugas_Besar_1214081_1214085.view
{
    partial class formHapusRokok
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
            this.lbID = new System.Windows.Forms.Label();
            this.cbIDRokok = new System.Windows.Forms.ComboBox();
            this.btHapus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(14, 62);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(24, 18);
            this.lbID.TabIndex = 15;
            this.lbID.Text = "ID";
            // 
            // cbIDRokok
            // 
            this.cbIDRokok.FormattingEnabled = true;
            this.cbIDRokok.Location = new System.Drawing.Point(67, 59);
            this.cbIDRokok.Name = "cbIDRokok";
            this.cbIDRokok.Size = new System.Drawing.Size(232, 21);
            this.cbIDRokok.TabIndex = 14;
            // 
            // btHapus
            // 
            this.btHapus.Location = new System.Drawing.Point(94, 104);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(129, 23);
            this.btHapus.TabIndex = 16;
            this.btHapus.Text = "Hapus";
            this.btHapus.UseVisualStyleBackColor = true;
            // 
            // formHapusRokok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 186);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.cbIDRokok);
            this.Name = "formHapusRokok";
            this.Text = "Hapus Rokok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.ComboBox cbIDRokok;
        private System.Windows.Forms.Button btHapus;
    }
}
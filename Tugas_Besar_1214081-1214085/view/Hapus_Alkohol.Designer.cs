namespace Tugas_Besar_1214081_1214085.view
{
    partial class formHapusAlkohol
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
            this.btHapus = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.cbIDAlkohol = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btHapus
            // 
            this.btHapus.Location = new System.Drawing.Point(94, 104);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(129, 23);
            this.btHapus.TabIndex = 19;
            this.btHapus.Text = "Hapus";
            this.btHapus.UseVisualStyleBackColor = true;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(14, 62);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(24, 18);
            this.lbID.TabIndex = 18;
            this.lbID.Text = "ID";
            // 
            // cbIDAlkohol
            // 
            this.cbIDAlkohol.FormattingEnabled = true;
            this.cbIDAlkohol.Location = new System.Drawing.Point(67, 59);
            this.cbIDAlkohol.Name = "cbIDAlkohol";
            this.cbIDAlkohol.Size = new System.Drawing.Size(232, 21);
            this.cbIDAlkohol.TabIndex = 17;
            // 
            // formHapusAlkohol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 186);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.cbIDAlkohol);
            this.Name = "formHapusAlkohol";
            this.Text = "Hapus Alkohol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.ComboBox cbIDAlkohol;
    }
}
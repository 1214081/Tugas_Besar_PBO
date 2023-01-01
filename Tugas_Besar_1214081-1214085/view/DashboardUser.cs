using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Besar_1214081_1214085.view
{
    public partial class formDashboardUser : Form
    {
        public formDashboardUser()
        {
            InitializeComponent();
        }

        private void menuProfile_Click(object sender, EventArgs e)
        {
            formProfileAccount profile = new formProfileAccount();
            profile.MdiParent = this;
            profile.Show();
        }

        private void menuAboutUs_Click(object sender, EventArgs e)
        {

        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah anda yakin ingin logout", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                this.Hide();
                formLogin login = new formLogin();
                login.ShowDialog();
                this.Close();
            }
        }

        private void menuInputRokok_Click(object sender, EventArgs e)
        {
            formInputRokok i_rokok = new formInputRokok();
            i_rokok.MdiParent = this;
            i_rokok.Show();
        }

        private void menuInputAlkohol_Click(object sender, EventArgs e)
        {
            formInputAlkohol i_alkohol = new formInputAlkohol();
            i_alkohol.MdiParent = this;
            i_alkohol.Show();
        }

        private void menuEditRokok_Click(object sender, EventArgs e)
        {
            formEditRokok e_rokok = new formEditRokok();
            e_rokok.MdiParent = this;
            e_rokok.Show();
        }

        private void menuEditAlkohol_Click(object sender, EventArgs e)
        {
            formEditAlkohol e_alkohol = new formEditAlkohol();
            e_alkohol.MdiParent = this;
            e_alkohol.Show();
        }

        private void menuHapusRokok_Click(object sender, EventArgs e)
        {
            formHapusRokok h_rokok = new formHapusRokok();
            h_rokok.MdiParent = this;
            h_rokok.Show();
        }

        private void menuHapusAlkohol_Click(object sender, EventArgs e)
        {
            formHapusAlkohol h_alkohol = new formHapusAlkohol();
            h_alkohol.MdiParent = this;
            h_alkohol.Show();
        }
    }
}

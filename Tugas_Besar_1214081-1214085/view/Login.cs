using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Besar_1214081_1214085.controller;
using Tugas_Besar_1214081_1214085.model;
using Tugas_Besar_1214081_1214085.view;

namespace Tugas_Besar_1214081_1214085
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btRegistrasi_Click(object sender, EventArgs e)
        {
            this.Hide();
            formRegistrasi registrasi = new formRegistrasi();
            registrasi.ShowDialog();
            this.Close();
            
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong !!!!");
            }
            else
            {
                string username = tbUsername.Text;
                string password = tbPassword.Text;
                Cek_Login login = new Cek_Login();
                M_User m_user = new M_User();
                bool statusAdmin = login.cekLoginAdmin(username, password);
                bool statusUser = login.cekLoginUser(username, password);
                if (statusAdmin)
                {
                    MessageBox.Show("Login Berhasil", "Berhasil");
                    this.Hide();
                    formDashboardAdmin dashboardAdmin = new formDashboardAdmin();
                    dashboardAdmin.ShowDialog();
                    this.Close();
                }
                else if (statusUser)
                {
                    MessageBox.Show("Login Berhasil", "Berhasil");
                    this.Hide();
                    formDashboardUser dashboardUser = new formDashboardUser();
                    dashboardUser.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal Login", "Gagal");
                }
            }
        }
    }
}

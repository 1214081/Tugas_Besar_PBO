using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Besar_1214081_1214085.model;
using Tugas_Besar_1214081_1214085.controller;

namespace Tugas_Besar_1214081_1214085
{
    public partial class formRegistrasi : Form
    {
        M_User m_user = new M_User();
        public formRegistrasi()
        {
            InitializeComponent();
        }

        private void formRegistrasi_Load(object sender, EventArgs e)
        {
            formLogin login = new formLogin();
            login.Close();
        }

        private void btRegistrasi_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "" )
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (tbConfirmPassword.Text == tbPassword.Text)
                {
                    Metode mthd = new Metode();
                    m_user.Username = tbUsername.Text;
                    m_user.Password = tbPassword.Text;

                    mthd.Insert(m_user);

                    tbUsername.Text = "";
                    tbPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Password tidak sama", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            formLogin login = new formLogin();
            login.ShowDialog();
            this.Close();
        }
    }
}

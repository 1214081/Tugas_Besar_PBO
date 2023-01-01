using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Besar_1214081_1214085.model;

namespace Tugas_Besar_1214081_1214085.controller
{
    internal class Metode
    {
        //Memanggik koneksi
        Koneksi koneksi = new Koneksi();

        //Metode simpan
        public bool Insert(M_User user)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO user (username,password) VALUES ('" + user.Username + "','" + user.Password +"')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}

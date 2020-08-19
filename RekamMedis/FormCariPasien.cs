using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace RekamMedis
{
    public partial class FormCariPasien : MetroFramework.Forms.MetroForm
    {
        funct funct = new funct();
        MySqlDataReader rd;
        public FormCariPasien()
        {
            InitializeComponent();
        }

        private void FormCariPasien_Load(object sender, EventArgs e)
        {
            metroTextBox5.Focus();
        }

        private void metroTextBox5_ButtonClick(object sender, EventArgs e)
        {
            MySqlConnection conn = funct.Getconn();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(@"SELECT * FROM pasien WHERE namapasien='"+ metroTextBox5.Text +"'", conn);
            rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                kodepasien.Text = rd["kodepasien"].ToString();
                namapasien.Text = rd["namapasien"].ToString();
                umur.Value = Convert.ToInt32(rd["umur"].ToString());
                jk.Text = rd["jk"].ToString();
                alamat.Text = rd["alamat"].ToString();
                button1.Enabled = true;
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Data yang anda cari tidak ditemukan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void metroTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                MySqlConnection conn = funct.Getconn();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(@"SELECT * FROM pasien WHERE namapasien='"+ metroTextBox5.Text +"'", conn);
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    kodepasien.Text = rd["kodepasien"].ToString();
                    namapasien.Text = rd["namapasien"].ToString();
                    umur.Value = Convert.ToInt32(rd["umur"].ToString());
                    jk.Text = rd["jk"].ToString();
                    alamat.Text = rd["alamat"].ToString();
                    button1.Enabled = true;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data pasien yang anda cari tidak ditemukan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            FormRekamMedik rkmmedik = new FormRekamMedik();
            rkmmedik.txtuser.Text = kodepasien.Text;
            rkmmedik.ShowDialog();
            rkmmedik = null;
            Close();
        }
    }
}

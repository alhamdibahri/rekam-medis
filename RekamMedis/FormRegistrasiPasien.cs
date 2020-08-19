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
    public partial class FormRegistrasiPasien : MetroFramework.Forms.MetroForm
    {
        funct funct = new funct();
        string jk;
        public FormRegistrasiPasien()
        {
            InitializeComponent();
        }
        void penomoranotomatis()
        {
            metroTextBox1.Text = funct.penomoranotomatis("pasien","PSN-","kodepasien");
        }
        void bersihkan()
        {
            metroTextBox2.Focus();
            metroTextBox2.Text = "";
            metroTextBox3.Text = "";
            metroTextBox4.Text = "";
            numericUpDown1.Value = 0;
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            metroRadioButton1.Checked = false;
            metroRadioButton2.Checked = false;
            penomoranotomatis();
        }
        private void FormRegistrasiPasien_Load(object sender, EventArgs e)
        {
            timer1.Start();
            penomoranotomatis();
            metroTextBox2.Focus();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbljam.Text = DateTime.Now.ToString("hh:mm");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this,"Apakah data yang sudah di inpukan benar ?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (metroTextBox1.Text == "" || metroTextBox2.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Kode pasien dana nama pasien kosong !", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string table = "pasien";
                    string column = "kodepasien,namapasien,tgl_lahir,jk,alamat,umur,tgl_daftar,jam_daftar,teleponpasien,status";
                    string values = @"'" + metroTextBox1.Text + "','" + metroTextBox2.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','"
                                    + jk + "','" + metroTextBox3.Text + "','" + numericUpDown1.Value + "','" + dateTimePicker2.Value.ToString("yyyy-MM-dd") 
                                    +"','"+ lbljam.Text +"','"+ metroTextBox4.Text +"','-'";
                    funct.insertdata(table,column,values);
                    MetroFramework.MetroMessageBox.Show(this, "Data Berhasil Di simpan", "Berhasil",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    bersihkan();
                }
            }
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton1.Checked == true)
            {
                jk = "Laki-Laki";
            }
            else
            {
                jk = "Perempuan";
            }
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton2.Checked == true)
            {
                jk = "Perempuan";
            }
            else
            {
                jk = "Laki-Laki";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bersihkan();
        }
    }
}

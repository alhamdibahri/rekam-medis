using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace RekamMedis
{
    public partial class FormAddPenyakit : MetroFramework.Forms.MetroForm
    {
        funct funct = new funct();
        public FormAddPenyakit()
        {
            InitializeComponent();
        }

        private void FormAddPenyakit_Load(object sender, EventArgs e)
        {
            metroTextBox1.Text =  funct.penomoranotomatis("penyakit","PNY-","id_penyakit");
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = funct.Getconn();
            string table = "penyakit";
            string column = "id_penyakit,nama_penyakit";
            string values = "'" + metroTextBox1.Text + "','" + metroTextBox5.Text + "'";
            funct.insertdata(table,column,values);
            this.Close();
        }
    }
}

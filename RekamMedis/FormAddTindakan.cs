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
    public partial class FormAddTindakan : MetroFramework.Forms.MetroForm
    {
        funct funct = new funct();
        public FormAddTindakan()
        {
            InitializeComponent();
        }

        private void FormAddTindakan_Load(object sender, EventArgs e)
        {
            metroTextBox1.Text = funct.penomoranotomatis("tindakan","TDK-","kodeTindakan");
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            string table = "tindakan";
            string column = "kodeTindakan,namaTindakan,harga_tindakan,ket";
            string values = "'"+ metroTextBox1.Text +"','"+ metroTextBox5.Text +"','"+ numericUpDown1.Value +"','-'";
            funct.insertdata(table,column,values);
            this.Close();
        }
    }
}

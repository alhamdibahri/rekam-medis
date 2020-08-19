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
    public partial class FormAddRwtInp : MetroFramework.Forms.MetroForm
    {
        funct funct = new funct();
        MySqlDataAdapter varDA = new MySqlDataAdapter();
        DataSet varDS = new DataSet();
        public delegate void DoEvent(string norm, string dokter, string diagnosa, string tgl_berobat);
        public event DoEvent RefreshDgv;
        public FormAddRwtInp()
        {
            InitializeComponent();
        }
        public void tampildokter()
        {
            MySqlConnection conn = funct.Getconn();
            string perintah = "SELECT kodeDokter, namaDokter FROM dokter";
            varDA = new MySqlDataAdapter(perintah, conn);
            varDA.Fill(varDS, "dokter");
            metroComboBox1.DataSource = varDS.Tables["dokter"];
            metroComboBox1.DisplayMember = "namaDokter";
            metroComboBox1.ValueMember = "kodeDokter";
            metroComboBox1.Text = "";
            metroComboBox1.SelectedValue = "";
        }
        private void FormAddRwtInp_Load(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Tambah")
            {
                this.RefreshDgv(metroTextBox2.Text, metroComboBox1.SelectedValue.ToString(), metroTextBox1.Text, metroDateTime1.Value.ToString("yyyy-MM-dd"));
            }
            else
            {
                this.RefreshDgv(metroComboBox1.SelectedValue.ToString(), metroTextBox1.Text, metroDateTime1.Value.ToString("yyyy-MM-dd"),metroLabel5.Text);
            }
            this.Close();
        }
    }
}

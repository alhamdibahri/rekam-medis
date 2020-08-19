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
    public partial class FormKeluhan : MetroFramework.Forms.MetroForm
    {
        funct funct = new funct();
        MySqlDataAdapter varDA = new MySqlDataAdapter();
        DataSet varDS = new DataSet();
        MySqlDataReader varDR;

        public delegate void DoEvent(string norm, string kodepasien, string namdokter, string keluhan, string diagnosa, string tindakan, string namatindakan, string kodekamar, string spesialis, string id_penyakit, string jam, string tanggal, string total);
        public event DoEvent RefreshDgv;
        public FormKeluhan()
        {
            InitializeComponent();
        }
        void tampildokter()
        {
            MySqlConnection conn = funct.Getconn();
            string perintah = "SELECT kodeDokter, namaDokter FROM dokter";
            varDA = new MySqlDataAdapter(perintah, conn);
            varDA.Fill(varDS, "dokter");
            nodokter.DataSource = varDS.Tables["dokter"];
            nodokter.DisplayMember = "namaDokter";
            nodokter.ValueMember = "kodeDokter";
            nodokter.Text = "";
            nodokter.SelectedValue = "";
        }
        private void FormKeluhan_Load(object sender, EventArgs e)
        {
            tampildokter();
            penomoranotomatis();
        }
        void penomoranotomatis()
        {
            norekam.Text = funct.penomoranotomatis("rekammedik","RMK-","nomorRm");
        }
        FormRekamMedik rekam = new FormRekamMedik();
        private void btnsimpan_Click(object sender, EventArgs e)
        {
            this.RefreshDgv(norekam.Text, metroLabel5.Text, nodokter.SelectedValue.ToString(), keluhan.Text, "", "", "", "", "", "", DateTime.Now.ToString("hh:mm"), metroDateTime1.Value.ToString("yyyy-MM-dd"),"");
            this.Close();
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}

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
using CrystalDecisions.CrystalReports.Engine;
namespace RekamMedis
{
    public partial class LaporanKunjunganPasien : Form
    {
        funct funct = new funct();
        MySqlDataAdapter varDA = new MySqlDataAdapter();
        MySqlCommand varComm = new MySqlCommand();
        DataSet varDS = new DataSet();
        DataTable dt = new DataTable();
        public LaporanKunjunganPasien()
        {
            InitializeComponent();
        }
        private DataTable Getdata()
        {
            MySqlConnection conn = funct.Getconn();
            MySqlDataAdapter da = new MySqlDataAdapter(@"SELECT kodepasien,namapasien,tgl_lahir,jk,tgl_daftar FROM pasien WHERE tgl_daftar BETWEEN '" + metroDateTime1.Value.ToString("yyyy-MM-dd") + "' AND '" + metroDateTime2.Value.ToString("yyyy-MM-dd") + "'", conn);
            dt = new DataTable();
            varDS = new DataSet();
            da.Fill(varDS);
            dt = varDS.Tables[0];
            return dt;
        }
        private void LaporanKunjunganPasien_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            metroGrid1.DataSource = Getdata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportClass rpt = new KunjunganPasien();
            rpt.SetDataSource(varDS.Tables[0]);

            // siapkan report viewer
            Form f1 = new ReportViewer(rpt);
            f1.ShowDialog();
            rpt.Close();
        }
    }
}

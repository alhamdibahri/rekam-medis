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
    public partial class LaporanPenyakit : Form
    {
        funct funct = new funct();
        MySqlDataAdapter varDA = new MySqlDataAdapter();
        MySqlCommand varComm = new MySqlCommand();
        DataSet varDS = new DataSet();
        DataTable dt = new DataTable();
        public LaporanPenyakit()
        {
            InitializeComponent();
        }
        private DataTable Getdata()
        {
            MySqlConnection conn = funct.Getconn();
            MySqlDataAdapter da = new MySqlDataAdapter(@"SELECT r.nomorRM,o.namapasien,p.nama_penyakit FROM rekammedik r, pasien o, penyakit p WHERE r.id_penyakit=p.id_penyakit AND r.kodepasien=o.kodepasien AND tgl_daftar BETWEEN '" + metroDateTime1.Value.ToString("yyyy-MM-dd") + "' AND '" + metroDateTime2.Value.ToString("yyyy-MM-dd") + "'", conn);
            dt = new DataTable();
            varDS = new DataSet();
            da.Fill(varDS);
            dt = varDS.Tables[0];
            return dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            metroGrid1.DataSource = Getdata();
        }

        private void LaporanPenyakit_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportClass rpt = new Penyakit();
            rpt.SetDataSource(varDS.Tables[0]);

            // siapkan report viewer
            Form f1 = new ReportViewer(rpt);
            f1.ShowDialog();
            rpt.Close();
        }
    }
}

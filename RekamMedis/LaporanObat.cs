using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CrystalDecisions.CrystalReports.Engine;
namespace RekamMedis
{
    public partial class LaporanObat : MetroFramework.Forms.MetroForm
    {
        funct funct = new funct();
        MySqlDataAdapter varDA = new MySqlDataAdapter();
        MySqlCommand varComm = new MySqlCommand();
        DataSet varDS = new DataSet();
        DataTable dt = new DataTable();
        public LaporanObat()
        {
            InitializeComponent();
        }
        private DataTable Getdata()
        {
            MySqlConnection conn = funct.Getconn();
            MySqlDataAdapter da = new MySqlDataAdapter(@"SELECT o.nama_obat,t.ambil,o.jmlh_obat FROM obat o LEFT JOIN tmp_obat t ON o.id_obat=t.id_obat WHERE tgl_ambil BETWEEN '" + metroDateTime1.Value.ToString("yyyy-MM-dd") + "' AND '" + metroDateTime2.Value.ToString("yyyy-MM-dd") + "'", conn);
            dt = new DataTable();
            varDS = new DataSet();
            da.Fill(varDS);
            dt = varDS.Tables[0];
            return dt;
        }
        void changegrid()
        {
            for (int x = 0; x < metroGrid1.RowCount -1; x++)
            {
                if (metroGrid1.Rows[x].Cells[1].Value.ToString() == "")
                {
                    //DataGridViewButtonCell txtcell = new DataGridViewButtonCell();
                    metroGrid1.Rows[x].Cells[1].Value = 0;
                    //txtcell.UseColumnTextForButtonValue = true;
                    //txtcell.Value = "Diagnosa Sekarang";
                }
            }
        }
        private void LaporanObat_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            metroGrid1.DataSource = Getdata();
            //changegrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportClass rpt = new Obat();
            rpt.SetDataSource(varDS.Tables[0]);

            // siapkan report viewer
            Form f1 = new ReportViewer(rpt);
            f1.ShowDialog();
            rpt.Close();
        }
    }
}

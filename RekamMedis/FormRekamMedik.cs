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
    public partial class FormRekamMedik : Form
    {
        funct funct = new funct();
        MySqlDataReader rd;
        FormCariPasien cri = new FormCariPasien();
        MySqlDataAdapter varDA = new MySqlDataAdapter();
        MySqlCommand varComm = new MySqlCommand();
        DataSet varDS = new DataSet();
        DataTable dt = new DataTable();
        public FormRekamMedik()
        {
            InitializeComponent();
        }
        void changegrid()
        {
            for (int x = 0; x < metroGrid1.RowCount; x++)
            {
                if (metroGrid1.Rows[x].Cells[6].Value.ToString() == "")
                {
                    DataGridViewButtonCell txtcell = new DataGridViewButtonCell();
                    metroGrid1.Rows[x].Cells[6] = txtcell;
                    txtcell.UseColumnTextForButtonValue = true;
                    txtcell.Value = "Diagnosa Sekarang";
                }
                if (metroGrid1.Rows[x].Cells[7].Value.ToString() == "Rawat Inap")
                {
                    DataGridViewButtonCell txtcell = new DataGridViewButtonCell();
                    metroGrid1.Rows[x].Cells[7] = txtcell;
                    txtcell.UseColumnTextForButtonValue = true;
                    txtcell.Value = "Rawat Inap";
                }
            }
        }
        private DataTable Getdata()
        {
           MySqlConnection conn = funct.Getconn();
           MySqlDataAdapter da = new MySqlDataAdapter(@"SELECT r.nomorRm,d.namaDokter,r.keluhan,r.diagnosa,r.namatindakan,r.tanggal FROM rekammedik r, dokter d
           WHERE r.kodeDokter=d.kodeDokter AND r.kodepasien='" + kodepasien.Text + "' ORDER BY nomorRm DESC", conn);
           dt = new DataTable();
           varDS = new DataSet();
           da.Fill(varDS);
           dt = varDS.Tables[0];
           return dt;
        }
        void fm_RefreshDgv(string norm,string kodepasien, string namdokter, string keluhan, string diagnosa, string tindakan, string namatindakan,string kodekamar, string spesialis,string id_penyakit, string jam, string tanggal, string total)
        {
            MySqlConnection conn = funct.Getconn();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO rekammedik (nomorRm,kodepasien,kodeDokter,keluhan,diagnosa,tindakan,namaTindakan,kodeKamar,spesialis,id_penyakit,jam,tanggal,totharga) VALUES(@a,@z,@b,@c,@d,@e,@k,@f,@g,@h,@i,@j,@o)", conn);
            cmd.Parameters.AddWithValue("@a", norm);
            cmd.Parameters.AddWithValue("@z", kodepasien);
            cmd.Parameters.AddWithValue("@b", namdokter);
            cmd.Parameters.AddWithValue("@c", keluhan);
            cmd.Parameters.AddWithValue("@d", diagnosa);
            cmd.Parameters.AddWithValue("@e", tindakan);
            cmd.Parameters.AddWithValue("@k", namatindakan);
            cmd.Parameters.AddWithValue("@f", kodekamar);
            cmd.Parameters.AddWithValue("@g", spesialis);
            cmd.Parameters.AddWithValue("@h", id_penyakit);
            cmd.Parameters.AddWithValue("@i", jam);
            cmd.Parameters.AddWithValue("@j", tanggal);
            cmd.Parameters.AddWithValue("@o", total);
            cmd.ExecuteNonQuery();
            metroGrid1.DataSource = Getdata();
            changegrid();
            record();
        }
        void updatedata(string a, string b, string z, string c, string d, string e, string f, string g)
        {
            MySqlConnection conn = funct.Getconn();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE rekammedik set diagnosa=@a,tindakan=@b,namatindakan=@z,kodeKamar=@c,spesialis=@d,id_penyakit=@e,totharga=@f WHERE nomorRm=@g", conn);
            cmd.Parameters.AddWithValue("@a", a);
            cmd.Parameters.AddWithValue("@b", b);
            cmd.Parameters.AddWithValue("@z", z);
            cmd.Parameters.AddWithValue("@c", c);
            cmd.Parameters.AddWithValue("@d", d);
            cmd.Parameters.AddWithValue("@e", e);
            cmd.Parameters.AddWithValue("@f", f);
            cmd.Parameters.AddWithValue("@g", g);
            cmd.ExecuteNonQuery();
            metroGrid1.DataSource = Getdata();
            changegrid();

        }
        void tampildatapasien()
        {
            MySqlConnection conn = funct.Getconn();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(@"SELECT * FROM pasien WHERE kodepasien='" + txtuser.Text + "'", conn);
            rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                kodepasien.Text = rd["kodepasien"].ToString();
                namapasien.Text = rd["namapasien"].ToString();
                umur.Value = Convert.ToInt32(rd["umur"].ToString());
                jk.Text = rd["jk"].ToString();
                alamat.Text = rd["alamat"].ToString();
            }
        }
        void record()
        {
            lblrecord.Text = metroGrid1.Rows.Count.ToString();
        }
        private void FormRekamMedik_Load(object sender, EventArgs e)
        {
            tampildatapasien();
            metroGrid1.DataSource = Getdata();
            changegrid();
            record();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormKeluhan keluhan = new FormKeluhan();
            keluhan.RefreshDgv += new FormKeluhan.DoEvent(fm_RefreshDgv);
            keluhan.metroLabel5.Text = kodepasien.Text;
            keluhan.ShowDialog();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.CurrentCell.Value.ToString() == "Diagnosa Sekarang")
            {
                FormDiagnosa diagnosa = new FormDiagnosa();
                diagnosa.pasien.Text = kodepasien.Text;
                diagnosa.rm.Text = dt.Rows[metroGrid1.CurrentCell.RowIndex][0].ToString();
                diagnosa.keluhan.Text = dt.Rows[metroGrid1.CurrentCell.RowIndex][2].ToString();
                diagnosa.diagnosa.Focus();
                diagnosa.RefreshDgv += new FormDiagnosa.DoEvent(updatedata);
                diagnosa.ShowDialog();
            }
                
            if (metroGrid1.CurrentCell.Value.ToString() == "Obat Pasien")
            {
                FormObatPasien obtpsn = new FormObatPasien();
                obtpsn.keluhan.Text = dt.Rows[metroGrid1.CurrentCell.RowIndex][2].ToString();
                obtpsn.diagnosa.Text = dt.Rows[metroGrid1.CurrentCell.RowIndex][3].ToString();
                obtpsn.norm.Text = dt.Rows[metroGrid1.CurrentCell.RowIndex][0].ToString();
                obtpsn.tindakan.Text = dt.Rows[metroGrid1.CurrentCell.RowIndex][4].ToString();
                obtpsn.dokter.Text = dt.Rows[metroGrid1.CurrentCell.RowIndex][1].ToString();
                obtpsn.ShowDialog();
            }
            if (metroGrid1.CurrentCell.Value.ToString() == "Hapus")
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Yakin ingin menghapus data ini ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string table = "rekammedik";
                    string where = "nomorRm='" + dt.Rows[metroGrid1.CurrentCell.RowIndex][0].ToString() + "'";
                    funct.deletedata(table, where);
                    metroGrid1.DataSource = Getdata();
                    record();
                }
            }
            
            
        }
        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.CurrentCell.Value.ToString() == "Rawat Inap")
            {
                FormRiwayatRawatInap frm2 = new FormRiwayatRawatInap();
                frm2.norm.Text = dt.Rows[metroGrid1.CurrentCell.RowIndex][0].ToString();
                frm2.keluhan.Text = dt.Rows[metroGrid1.CurrentCell.RowIndex][2].ToString();
                frm2.pasien.Text = kodepasien.Text;
                frm2.tindakan.Text = "Rawat Inap";
                frm2.ShowDialog();
            }
            if (metroGrid1.CurrentCell.Value.ToString() == "Print Struk")
            {
                MySqlConnection conn = funct.Getconn();
                DataSet ds = new DataSet();
                string perintah = @"SELECT r.nomorRm,p.namapasien,r.tanggal,p.umur,t.namaTindakan,
r.totharga,o.harga,o.nama_obat FROM rekammedik r, obat o, tmp_obat m, pasien p, tindakan t
                                 WHERE r.nomorRm='" + dt.Rows[metroGrid1.CurrentCell.RowIndex][0].ToString() 
                                                    + "' AND m.nomorRm=r.nomorRm AND p.kodepasien=r.kodepasien AND o.id_obat=m.id_obat AND r.tindakan=t.kodeTindakan";
                MySqlDataAdapter da = new MySqlDataAdapter(perintah, conn);
                da.Fill(ds, "Struk");

                ReportClass rpt = new Struck();
                rpt.SetDataSource(ds.Tables["Struk"]);

                // siapkan report viewer
                Form f1 = new ReportViewer(rpt);
                f1.ShowDialog();
                rpt.Close();
            }
        }
    }
}

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
    public partial class FormRiwayatRawatInap : Form
    {
        funct funct = new funct();
        MySqlDataAdapter varDA = new MySqlDataAdapter();
        MySqlCommand varComm = new MySqlCommand();
        DataSet varDS = new DataSet();
        DataTable dt = new DataTable();
        MySqlDataReader dr;
        public FormRiwayatRawatInap()
        {
            InitializeComponent();
        }
        private DataTable Getdata()
        {
            MySqlConnection conn = funct.Getconn();
            MySqlDataAdapter da = new MySqlDataAdapter(@"SELECT ri.id,ri.nomorRm,d.namaDokter,ri.diagnosa,ri.tgl_berobat FROM rawat_inap ri, dokter d WHERE ri.dokter=d.kodeDokter", conn);
            dt = new DataTable();
            varDS = new DataSet();
            da.Fill(varDS);
            dt = varDS.Tables[0];
            return dt;
        }
        void fm_RefreshDgv(string norm, string dokter, string diagnosa, string tgl_berobat)
        {
            MySqlConnection conn = funct.Getconn();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO rawat_inap(nomorRm,dokter,diagnosa,tgl_berobat) VALUES(@a,@b,@c,@d)", conn);
            cmd.Parameters.AddWithValue("@a", norm);
            cmd.Parameters.AddWithValue("@b", dokter);
            cmd.Parameters.AddWithValue("@c", diagnosa);
            cmd.Parameters.AddWithValue("@d", tgl_berobat);
            cmd.ExecuteNonQuery();
            dataGridView1.DataSource = Getdata();
        }
        void tampilnokmar()
        {
            MySqlConnection conn = funct.Getconn();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT kodeKamar FROM rekammedik WHERE nomorRm='"+ norm.Text +"'", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    metroTextBox1.Text = dr["kodeKamar"].ToString();
                }
            }
            finally
            {
                conn.Close();
                dr.Close();
            }
        }
        void tampilkamar()
        {
            MySqlConnection conn = funct.Getconn();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM kamar WHERE kodeKamar='" + metroTextBox1.Text + "'", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    metroTextBox2.Text = dr["namaKamar"].ToString();
                    metroTextBox3.Text = dr["lantai_kamar"].ToString();
                }
            }
            finally
            {
                conn.Close();
                dr.Close();
            }
        }
        void tampilpasien()
        {
            MySqlConnection conn = funct.Getconn();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM pasien WHERE kodepasien='" + pasien.Text + "'", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr["status"].ToString() == "Rawat Inap")
                    {
                        button1.Visible = true;
                        button3.Visible = true;
                    }
                    else
                    {
                        button1.Visible = false;
                        button3.Visible = false;
                    }
                }
            }
            finally
            {
                conn.Close();
                dr.Close();
            }
        }
        void editdata(string dokter, string diagnosa, string tgl_berobat, string id)
        {
            MySqlConnection conn = funct.Getconn();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE rawat_inap set dokter=@a,diagnosa=@b,tgl_berobat=@c WHERE id=@d", conn);
            cmd.Parameters.AddWithValue("@a", dokter);
            cmd.Parameters.AddWithValue("@b", diagnosa);
            cmd.Parameters.AddWithValue("@c", tgl_berobat);
            cmd.Parameters.AddWithValue("@d", id);
            cmd.ExecuteNonQuery();
            dataGridView1.DataSource = Getdata();
        }
        private void FormRiwayatRawatInap_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Getdata();
            tampilnokmar();
            tampilkamar();
            tampilpasien();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            FormAddRwtInp frm = new FormAddRwtInp();
            frm.tampildokter();
            frm.RefreshDgv += new FormAddRwtInp.DoEvent(fm_RefreshDgv);
            frm.metroTextBox2.Text = norm.Text;
            frm.ShowDialog();
            
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.Value.ToString() == "Edit")
            {
                FormAddRwtInp frm = new FormAddRwtInp();
                frm.tampildokter();
                frm.lblid.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex][0].ToString();
                frm.metroTextBox2.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex][1].ToString();
                frm.metroComboBox1.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex][2].ToString();
                frm.metroTextBox1.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex][3].ToString();
                frm.metroDateTime1.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex][4].ToString();
                frm.metroLabel5.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex][0].ToString();
                frm.button2.Text = "Edit";
                frm.RefreshDgv += new FormAddRwtInp.DoEvent(editdata);
                frm.ShowDialog();
            }
            if (dataGridView1.CurrentCell.Value.ToString() == "Hapus")
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Yakin ingin menghapus data ini ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string table = "rawat_inap";
                    string where = "id='" + dt.Rows[dataGridView1.CurrentCell.RowIndex][0].ToString() + "'";
                    funct.deletedata(table, where);
                    dataGridView1.DataSource = Getdata();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tablepasien = "pasien";
            string setpasien = "status='-'";
            string wherepasien = "kodepasien='" + pasien.Text + "'";
            string tablekmar = "kamar";
            string setkamar = "status='-'";
            string wherekamar = "kodeKamar='" + metroTextBox1.Text + "'";
            funct.updatedata(tablepasien, setpasien, wherepasien);
            funct.updatedata(tablekmar, setkamar, wherekamar);
            this.Close();
        }
    }
}

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
    public partial class FormObatPasien : Form
    {
        funct funct = new funct();
        MySqlDataAdapter varDA = new MySqlDataAdapter();
        DataSet varDS = new DataSet();
        MySqlDataReader varDR;
        DataTable dt = new DataTable();
        public FormObatPasien()
        {
            InitializeComponent();
        }
        void tampilobat()
        {
            MySqlConnection conn = funct.Getconn();
            string perintah = "SELECT id_obat, nama_obat FROM obat";
            varDA = new MySqlDataAdapter(perintah, conn);
            varDA.Fill(varDS, "obat");
            metroComboBox1.DataSource = varDS.Tables["obat"];
            metroComboBox1.DisplayMember = "nama_obat";
            metroComboBox1.ValueMember = "id_obat";
            metroComboBox1.Text = "";
            metroComboBox1.SelectedValue = "";
        }
        private DataTable tampildata()
        {
            MySqlConnection conn = funct.Getconn();
            varDA = new MySqlDataAdapter("SELECT t.id_temp,t.nomorRm,o.nama_obat,t.ambil,t.tgl_ambil FROM tmp_obat t, obat o WHERE o.id_obat=t.id_obat AND nomorRM='"+ norm.Text +"'", conn);
            dt = new DataTable();
            varDS = new DataSet();
            varDA.Fill(varDS);
            dt = varDS.Tables[0];
            return dt;
        }
        private void FormObatPasien_Load(object sender, EventArgs e)
        {
            tampilobat();
            dataGridView1.DataSource =  tampildata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void bersihkan()
        {
            metroComboBox1.SelectedIndex = -1;
            numericUpDown1.Value = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = funct.Getconn();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM obat WHERE id_obat='" + metroComboBox1.SelectedValue.ToString() + "'", conn);
            varDR = cmd.ExecuteReader();
            if (varDR.Read())
            {
                if (numericUpDown1.Value > int.Parse(varDR["jmlh_obat"].ToString()))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Stok obat tidak cukup untuk melakukan transaksi ! ", "Pesan kesalahan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string table = "tmp_obat";
                    string column = "nomorRm,id_obat,ambil,jam_ambil,tgl_ambil";
                    string values = "'"+ norm.Text +"','"+ metroComboBox1.SelectedValue.ToString() +"','"+ numericUpDown1.Value +"','"+ DateTime.Now.ToString("hh:mm") +"','"+ DateTime.Now.ToString("yyyy-MM-dd") +"'";
                    funct.insertdata(table,column,values);
                    dataGridView1.DataSource = tampildata();
                    bersihkan();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.Value.ToString() == "Hapus")
            {
                string table = "tmp_obat";
                string where = "id_temp='" + dt.Rows[dataGridView1.CurrentCell.RowIndex][0].ToString() +"'";
                funct.deletedata(table, where);
                dataGridView1.DataSource = tampildata();
            }
        }
    }
}

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
    public partial class FormDiagnosa : MetroFramework.Forms.MetroForm
    {
        funct funct = new funct();
        MySqlDataAdapter varDA = new MySqlDataAdapter();
        DataSet varDS = new DataSet();
        public delegate void DoEvent(string a, string b, string z, string c, string d, string e, string f, string k);
        public event DoEvent RefreshDgv;
        MySqlDataReader varDR;
        public FormDiagnosa()
        {
            InitializeComponent();
        }

        private void FormDiagnosa_Load(object sender, EventArgs e)
        {
            diagnosa.Focus();
            tampilpenyakit();
            tampiltindakan();
            tarif.Text = "";
        }
        public void tampilpenyakit()
        {
            MySqlConnection conn = funct.Getconn();
            string perintah = "SELECT id_penyakit, nama_penyakit FROM penyakit ORDER BY nama_penyakit ASC";
            varDA = new MySqlDataAdapter(perintah, conn);
            varDA.Fill(varDS, "penyakit");
            penyakit.DataSource = varDS.Tables["penyakit"];
            penyakit.DisplayMember = "nama_penyakit";
            penyakit.ValueMember = "id_penyakit";
            penyakit.Text = "";
            penyakit.SelectedValue = "";
        }
        void tampiltindakan()
        {
            MySqlConnection conn = funct.Getconn();
            string perintah = "SELECT kodeTindakan, namaTindakan FROM tindakan ORDER BY namaTindakan ASC";
            varDA = new MySqlDataAdapter(perintah, conn);
            varDA.Fill(varDS, "tindakan");
            tindakan.DataSource = varDS.Tables["tindakan"];
            tindakan.DisplayMember = "namaTindakan";
            tindakan.ValueMember = "kodeTindakan";
            tindakan.Text = "";
            tindakan.SelectedValue = "";
        }
        void tampilkamar()
        {
            MySqlConnection conn = funct.Getconn();
            string perintah = "SELECT kodeKamar, namaKamar FROM kamar WHERE status='-' AND ket='-' ORDER BY namaKamar";
            varDA = new MySqlDataAdapter(perintah, conn);
            varDA.Fill(varDS, "kamar");
            combobox.DataSource = varDS.Tables["kamar"];
            combobox.DisplayMember = "namaKamar";
            combobox.ValueMember = "kodeKamar";
            combobox.Text = "";
            combobox.SelectedValue = "";
        }
        void tampilspesialis()
        {
            MySqlConnection conn = funct.Getconn();
            string perintah = "SELECT kodespealis, nama_spesialis FROM konsul_spesial ORDER BY nama_spesialis";
            varDA = new MySqlDataAdapter(perintah, conn);
            varDA.Fill(varDS, "konsul_spesial");
            combobox.DataSource = varDS.Tables["konsul_spesial"];
            combobox.DisplayMember = "nama_spesialis";
            combobox.ValueMember = "kodespealis";
            combobox.Text = "";
            combobox.SelectedValue = "";
        }
        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = funct.Getconn();
            if (tindakan.Text == "Rawat Inap")
            {
                varDA.Fill(varDS, "konsul_spesial");
                varDS.Tables["konsul_spesial"].Clear();
                tampilkamar();
                combobox.Name = "kamar";
                combobox.Visible = true;
                txtlabel.Text = "Nama Kamar";
                txtlabel.Visible = true;
                metroLabel5.Visible = true;
                metroLabel6.Visible = true;
                metroTextBox1.Visible = true;
                metroTextBox2.Visible = true;
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM tindakan WHERE kodeTindakan='"+ tindakan.SelectedValue.ToString() +"'", conn);
                    varDR = cmd.ExecuteReader();
                    if (varDR.Read())
                    {
                        tarif.Text = varDR["harga_tindakan"].ToString();
                    }
                }
                finally
                {
                    conn.Close();
                }
            }
            else if (tindakan.Text == "Konsultasi Dokter Spesialis")
            {
                varDA.Fill(varDS, "kamar");
                varDS.Tables["kamar"].Clear();
                tampilspesialis();
                combobox.Name = "spesialis";
                combobox.Visible = true;
                txtlabel.Text = "Spesialis";
                txtlabel.Visible = true;
                metroLabel5.Visible = false;
                metroLabel6.Visible = false;
                metroTextBox1.Visible = false;
                metroTextBox2.Visible = false;
                metroTextBox1.Text = "";
                metroTextBox2.Text = "";
            }
            else
            {
                varDA.Fill(varDS, "kamar");
                varDS.Tables["kamar"].Clear();
                varDA.Fill(varDS, "konsul_spesial");
                varDS.Tables["konsul_spesial"].Clear();
                combobox.Name = "no";
                combobox.Visible = false;
                txtlabel.Visible = false;
                metroLabel5.Visible = false;
                metroLabel6.Visible = false;
                metroTextBox1.Visible = false;
                metroTextBox2.Visible = false;
                metroTextBox1.Text = "";
                metroTextBox2.Text = "";
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM tindakan WHERE namaTindakan='" + tindakan.Text + "'", conn);
                    varDR = cmd.ExecuteReader();
                    if (varDR.Read())
                    {
                        tarif.Text = varDR["harga_tindakan"].ToString();
                    }
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (combobox.Name == "spesialis")
            {
                this.RefreshDgv(diagnosa.Text, tindakan.SelectedValue.ToString(), tindakan.Text, "", combobox.SelectedValue.ToString(), penyakit.SelectedValue.ToString(), tarif.Text, rm.Text);
                this.Close();
            }
            else if (combobox.Name == "kamar")
            {
                this.RefreshDgv(diagnosa.Text, tindakan.SelectedValue.ToString(), tindakan.Text, combobox.SelectedValue.ToString(), "", penyakit.SelectedValue.ToString(), tarif.Text, rm.Text);
                string tablepasien = "pasien";
                string setpasien = "status='Rawat Inap'";
                string wherepasien = "kodepasien='"+ pasien.Text +"'";
                string tablekmar = "kamar";
                string setkamar = "status='Full'";
                string wherekamar = "kodeKamar='"+ metroTextBox1.Text +"'";
                funct.updatedata(tablepasien, setpasien, wherepasien);
                funct.updatedata(tablekmar, setkamar, wherekamar);
                this.Close();
            }
            else if (combobox.Name == "no")
            {
                this.RefreshDgv(diagnosa.Text, tindakan.SelectedValue.ToString(), tindakan.Text, "", "", penyakit.SelectedValue.ToString(), tarif.Text, rm.Text);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddPenyakit frm2 = new FormAddPenyakit();
            frm2.ShowDialog();
            varDA.Fill(varDS, "penyakit");
            varDS.Tables["penyakit"].Clear();
            tampilpenyakit();
        }

        private void combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = funct.Getconn();
            if (combobox.Name == "kamar")
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM kamar WHERE namaKamar='" + combobox.Text + "'", conn);
                    MySqlDataReader varDR;
                    varDR = cmd.ExecuteReader();
                    if (varDR.Read())
                    {
                        metroTextBox1.Text = varDR["kodeKamar"].ToString();
                        metroTextBox2.Text = varDR["lantai_kamar"].ToString();
                    }
                }
                finally
                {
                    conn.Close();
                }
            }
            if (combobox.Name == "spesialis")
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM konsul_spesial WHERE nama_spesialis='" + combobox.Text + "'", conn);
                    varDR = cmd.ExecuteReader();
                    if (varDR.Read())
                    {
                        tarif.Text = varDR["harga_spesialis"].ToString();
                    }
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAddTindakan frm2 = new FormAddTindakan();
            frm2.ShowDialog();
            varDA.Fill(varDS, "tindakan");
            varDS.Tables["tindakan"].Clear();
            tampiltindakan();
        }
    }
}

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
    public partial class FormJadwalDokter : MetroFramework.Forms.MetroForm
    {
        funct funct = new funct();
        MySqlDataAdapter varDA = new MySqlDataAdapter();
        MySqlDataReader varDR;
        MySqlCommand varComm = new MySqlCommand();
        DataSet varDS = new DataSet();
        DataTable dt;
        public FormJadwalDokter()
        {
            InitializeComponent();
        }
        void tampildata()
        {
           string perintah = @"SELECT j.kodeJadwal,j.kodeDokter,d.namaDokter,d.spesialis,j.waktu 
                              FROM jadwal_dokter j, dokter d WHERE d.kodeDokter=j.kodeDokter";
           varDA = new MySqlDataAdapter(perintah, funct.Getconn());
           dt = new DataTable();
           varDS = new DataSet();
           dt = varDS.Tables.Add("DetailJadwal");
           varDA.Fill(varDS, "DetailJadwal");
           dataGridView1.DataSource = varDS.Tables["DetailJadwal"];
        }
        private void FormJadwalDokter_Load(object sender, EventArgs e)
        {
            dgvstyle();
            tampildokter();
            tampildata();
            hitungrecord();
        }
        void hitungrecord()
        {
            lblrecord.Text = varDS.Tables["DetailJadwal"].Rows.Count.ToString();
        }
        void tampildokter()
        {
            MySqlConnection conn = funct.Getconn();
            string perintah = "SELECT kodeDokter, namaDokter FROM dokter";
            varDA = new MySqlDataAdapter(perintah, conn);
            varDA.Fill(varDS, "dokter");
            kodeDokter.DataSource = varDS.Tables["dokter"];
            kodeDokter.DisplayMember = "kodeDokter";
            kodeDokter.ValueMember = "kodeDokter";
            kodeDokter.Text = "";
            kodeDokter.SelectedValue = "";
            penomoranotomatis();
        }
        void penomoranotomatis()
        {
            kodeJadwal.Text = funct.penomoranotomatis("jadwal_dokter", "JWD-", "kodeJadwal");
        }
        void dgvstyle()
        {
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
        }
        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = funct.Getconn();
            conn.Open();
            string perintah = "SELECT * FROM dokter WHERE kodeDokter='"+ kodeDokter.Text +"'";
            varComm = new MySqlCommand(perintah, conn);
            varDR = varComm.ExecuteReader();
            if (varDR.Read())
            {
               namaDokter.Text = varDR["namaDokter"].ToString();
               spesialis.Text = varDR["spesialis"].ToString();
            }
        }
        void bersihkan()
        {
            kodeJadwal.Text = "";
            kodeDokter.ResetText();
            waktu.Text = "";
            namaDokter.Text = "";
            spesialis.Text = "";
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                kodeJadwal.Text = Convert.ToString(varDS.Tables["DetailJadwal"].Rows[dataGridView1.CurrentRow.Index].ItemArray[0]);
                kodeDokter.Text = Convert.ToString(varDS.Tables["DetailJadwal"].Rows[dataGridView1.CurrentRow.Index].ItemArray[1]);
                namaDokter.Text = Convert.ToString(varDS.Tables["DetailJadwal"].Rows[dataGridView1.CurrentRow.Index].ItemArray[2]);
                spesialis.Text = Convert.ToString(varDS.Tables["DetailJadwal"].Rows[dataGridView1.CurrentRow.Index].ItemArray[3]);
                waktu.Text = Convert.ToString(varDS.Tables["DetailJadwal"].Rows[dataGridView1.CurrentRow.Index].ItemArray[4]);
            }
            catch (Exception)
            {
                bersihkan();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bersihkan();
            penomoranotomatis();
        }
        private void btnsimpan_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = funct.Getconn();
            try
            {
                if (kodeJadwal.Text == "" || kodeDokter.Text == "" || waktu.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data masih ada yang kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string table = "jadwal_dokter";
                    string column = "kodeJadwal,kodeDokter,waktu";
                    string values = "'"+ kodeJadwal.Text +"','"+ kodeDokter.Text +"','" + waktu.Text  +"'";
                    funct.insertdata(table,column,values);
                    MetroFramework.MetroMessageBox.Show(this, "Data berhasil di simpan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tampildata();
                    bersihkan();
                    hitungrecord();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        private void btnhapus_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = funct.Getconn();
            try
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Yakin Ingin menghapus data ini?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (kodeJadwal.Text == "")
                    {
                        MetroFramework.MetroMessageBox.Show(this, "pilih kode jadwal yang akan di hapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string table = "jadwal_dokter";
                        string where = "kodeJadwal='"+ kodeJadwal.Text +"'";
                        funct.deletedata(table,where);
                        MetroFramework.MetroMessageBox.Show(this, "Data berhasil di hapus", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tampildata();
                        bersihkan();
                        hitungrecord();
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = funct.Getconn();
            try
            {
                if (kodeJadwal.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "pilih kode jadwal yang akan di ubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string table = "jadwal_dokter";
                    string set = "kodeDokter='"+ kodeDokter.Text +"',waktu='"+ waktu.Text +"'";
                    string where = "kodeJadwal='" + kodeJadwal.Text + "'";
                    funct.updatedata(table, set, where);
                    MetroFramework.MetroMessageBox.Show(this, "Data berhasil di ubah", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tampildata();
                    bersihkan();
                    hitungrecord();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bersihkan();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTextBox5_ButtonClick(object sender, EventArgs e)
        {
            string sql = "";
            if (comboBox1.Text == "Kode Jadwal")
            {
                sql = @"SELECT j.kodeJadwal,j.kodeDokter,d.namaDokter,d.spesialis,j.waktu 
                              FROM jadwal_dokter j, dokter d WHERE d.kodeDokter=j.kodeDokter AND kodeJadwal LIKE '%" + metroTextBox5.Text + "%'";
            }
            else if (comboBox1.Text == "Nama Dokter")
            {
                sql = @"SELECT j.kodeJadwal,j.kodeDokter,d.namaDokter,d.spesialis,j.waktu 
                              FROM jadwal_dokter j, dokter d WHERE d.kodeDokter=j.kodeDokter AND d.namaDokter LIKE '%" + metroTextBox5.Text + "%'";
            }
            else if (comboBox1.Text == "Waktu")
            {
                sql = @"SELECT j.kodeJadwal,j.kodeDokter,d.namaDokter,d.spesialis,j.waktu 
                              FROM jadwal_dokter j, dokter d WHERE d.kodeDokter=j.kodeDokter AND j.waktu LIKE '%" + metroTextBox5.Text + "%'";
            }
            dataGridView1.DataSource = funct.cari(sql);
        }
    }
}

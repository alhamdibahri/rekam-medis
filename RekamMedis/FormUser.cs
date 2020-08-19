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
    public partial class FormUser : MetroFramework.Forms.MetroForm
    {
        funct funct = new funct();
        DataSet varDS = new DataSet();
        MySqlDataAdapter varDA = new MySqlDataAdapter();
        MySqlCommand varComm = new MySqlCommand();
        DataRow varRow;
        public FormUser()
        {
            InitializeComponent();
        }
        void tampildata()
        {
            string perintah = "select * from user_man";
            varDA = new MySqlDataAdapter(perintah, funct.Getconn());
            varDA.Fill(varDS, "user_man");
            dataGridView1.DataSource = varDS.Tables["user_man"];
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
        private void Form1_Load(object sender, EventArgs e)
        {
            tampildata();
            dgvstyle();
            hitungrecord();
        }
        void hitungrecord()
        {
            lblrecord.Text = varDS.Tables["user_man"].Rows.Count.ToString();
        }
        void bersihkan()
        {
            metroTextBox1.Text = "";
            metroTextBox2.Text = "";
            metroTextBox3.Text = "";
            metroTextBox4.Text = "";
            metroComboBox1.ResetText();
            metroComboBox2.ResetText();
        }
        void penomoranotomatis()
        {
            metroTextBox1.Text = funct.penomoranotomatis("user_man", "USR-", "kodeuser");
        }
        private void btnubah_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBox1.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Pilih kode user yang akan di ubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DataColumn[] pk = { varDS.Tables["user_man"].Columns["kodeuser"] };
                    varDS.Tables["user_man"].PrimaryKey = pk;
                    varRow = varDS.Tables["user_man"].Rows.Find(metroTextBox1.Text);
                    if (varRow == null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Kode user tidak terdaftar untuk di ubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        varRow.BeginEdit();
                        varRow[1] = metroTextBox2.Text;
                        varRow[2] = metroComboBox1.Text;
                        varRow[3] = metroTextBox3.Text;
                        varRow[4] = funct.CreateMD5Hash(metroTextBox4.Text);
                        varRow[5] = metroComboBox2.Text;
                        varRow.EndEdit();
                        MySqlCommandBuilder cmd = new MySqlCommandBuilder(varDA);
                        varDA.Update(varDS, "user_man");
                        MetroFramework.MetroMessageBox.Show(this, "Data berhasil di ubah", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersihkan();
                        hitungrecord();
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = funct.Getconn();
            try
            {
                if (metroTextBox1.Text == "" || metroTextBox2.Text == "" || metroComboBox1.Text == "" || metroTextBox3.Text == "" || metroTextBox4.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data masih ada yang kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DataColumn[] pk = { varDS.Tables["user_man"].Columns["kodeuser"] };
                    varDS.Tables["user_man"].PrimaryKey = pk;
                    varRow = varDS.Tables["user_man"].Rows.Find(metroTextBox1.Text);
                    if (varRow == null)
                    {
                        varRow = varDS.Tables["user_man"].NewRow();
                        varRow[0] = metroTextBox1.Text;
                        varRow[1] = metroTextBox2.Text;
                        varRow[2] = metroComboBox1.Text;
                        varRow[3] = metroTextBox3.Text;
                        varRow[4] = funct.CreateMD5Hash(metroTextBox4.Text);
                        varRow[5] = metroComboBox2.Text;
                        varDS.Tables["user_man"].Rows.Add(varRow);
                        MySqlCommandBuilder cmd = new MySqlCommandBuilder(varDA);
                        varDA.Update(varDS, "user_man");
                        MetroFramework.MetroMessageBox.Show(this, "Data berhasil di simpan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersihkan();
                        hitungrecord();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Kode user sudah ada", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTextBox5_TextChanged(object sender, EventArgs e)
        {
            string sql = @"SELECT * FROM user_man WHERE kodeuser LIKE '%" + metroTextBox5.Text + 
                        "%' OR nama LIKE '%" + metroTextBox5.Text + "%' OR jk LIKE '%" + metroTextBox5.Text + 
                        "%' OR username LIKE '%" + metroTextBox5.Text + "%'";
            dataGridView1.DataSource = funct.cari(sql);
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Yakin ingin menghapus data ini?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (metroTextBox1.Text == "")
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Pilih kode user yang akan di hapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        DataColumn[] pk = { varDS.Tables["user_man"].Columns["kodeuser"] };
                        varDS.Tables["user_man"].PrimaryKey = pk;
                        varRow = varDS.Tables["user_man"].Rows.Find(metroTextBox1.Text);
                        if (varRow == null)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Kode user tidak terdaftar untuk di hapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            varRow.Delete();
                            MySqlCommandBuilder cmd = new MySqlCommandBuilder(varDA);
                            varDA.Update(varDS, "user_man");
                            MetroFramework.MetroMessageBox.Show(this, "Data berhasil di hapus", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bersihkan();
                            hitungrecord();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bersihkan();
            metroTextBox2.Focus();
            penomoranotomatis();
        }
        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                metroTextBox1.Text = Convert.ToString(varDS.Tables["user_man"].Rows[dataGridView1.CurrentRow.Index].ItemArray[0]);
                metroTextBox2.Text = Convert.ToString(varDS.Tables["user_man"].Rows[dataGridView1.CurrentRow.Index].ItemArray[1]);
                metroComboBox1.Text = Convert.ToString(varDS.Tables["user_man"].Rows[dataGridView1.CurrentRow.Index].ItemArray[2]);
                metroTextBox3.Text = Convert.ToString(varDS.Tables["user_man"].Rows[dataGridView1.CurrentRow.Index].ItemArray[3]);
                metroTextBox4.Text = Convert.ToString(varDS.Tables["user_man"].Rows[dataGridView1.CurrentRow.Index].ItemArray[4]);
                metroComboBox2.Text = Convert.ToString(varDS.Tables["user_man"].Rows[dataGridView1.CurrentRow.Index].ItemArray[5]);
            }
            catch (Exception)
            {
                bersihkan();
                penomoranotomatis();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bersihkan();
        }
    }
}

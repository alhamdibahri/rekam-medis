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
    public partial class FormObat : MetroFramework.Forms.MetroForm
    {
        funct funct = new funct();
        MySqlDataAdapter varDA = new MySqlDataAdapter();
        DataRow varRow;
        MySqlCommand varComm = new MySqlCommand();
        DataSet varDS = new DataSet();
        public FormObat()
        {
            InitializeComponent();
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
        void tampildata()
        {
            varDA = new MySqlDataAdapter("SELECT * FROM obat", funct.Getconn());
            varDA.Fill(varDS, "obat");
            dataGridView1.DataSource = varDS.Tables["obat"];
        }
        private void FormObat_Load(object sender, EventArgs e)
        {
            dgvstyle();
            tampildata();
            hitungrecord();
        }
        void hitungrecord()
        {
            lblrecord.Text = varDS.Tables["obat"].Rows.Count.ToString();
        }
        void bersihkan()
        {
            metroTextBox1.Text = "";
            metroTextBox2.Text = "";
            metroTextBox3.Text = "";
            metroTextBox4.Text = "";
            metroTextBox5.Text = "";
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                metroTextBox1.Text = Convert.ToString(varDS.Tables["obat"].Rows[dataGridView1.CurrentRow.Index].ItemArray[1]);
                metroTextBox2.Text = Convert.ToString(varDS.Tables["obat"].Rows[dataGridView1.CurrentRow.Index].ItemArray[2]);
                metroTextBox3.Text = Convert.ToString(varDS.Tables["obat"].Rows[dataGridView1.CurrentRow.Index].ItemArray[3]);
                metroTextBox4.Text = Convert.ToString(varDS.Tables["obat"].Rows[dataGridView1.CurrentRow.Index].ItemArray[4]);
                metroTextBox5.Text = Convert.ToString(varDS.Tables["obat"].Rows[dataGridView1.CurrentRow.Index].ItemArray[0]);
            }
            catch (Exception)
            {
                bersihkan();
                penomoranotoamtis();
            }
        }
        void penomoranotoamtis()
        {
            metroTextBox5.Text = funct.penomoranotomatis("obat","OBT-","id_obat");
        }
        private void btnsimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (@"" + metroTextBox1.Text == "" ||
                    metroTextBox2.Text == "" || metroTextBox3.Text == ""
                    || metroTextBox4.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data masih kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DataColumn[] pk = {varDS.Tables["obat"].Columns["id_obat"] };
                    varDS.Tables["obat"].PrimaryKey = pk;
                    varRow = varDS.Tables["obat"].Rows.Find(metroTextBox5.Text);
                    if (varRow == null)
                    {
                        varRow = varDS.Tables["obat"].NewRow();
                        varRow[0] = metroTextBox5.Text;
                        varRow[1] = metroTextBox1.Text;
                        varRow[2] = metroTextBox2.Text;
                        varRow[3] = metroTextBox3.Text;
                        varRow[4] = metroTextBox4.Text;
                        varDS.Tables["obat"].Rows.Add(varRow);
                        MySqlCommandBuilder cmd = new MySqlCommandBuilder(varDA);
                        varDA.Update(varDS, "obat");
                        MetroFramework.MetroMessageBox.Show(this, "Data berhasil di simpan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tampildata();
                        bersihkan();
                        hitungrecord();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Kode obat sudah ada", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            try
            {
                if(MetroFramework.MetroMessageBox.Show(this, "Yakin ingin menghapus data ini?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (metroTextBox1.Text == "")
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Pilih kode obat yang akan di hapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        DataColumn[] pk = { varDS.Tables["obat"].Columns["id_obat"] };
                        varDS.Tables["obat"].PrimaryKey = pk;
                        varRow = varDS.Tables["obat"].Rows.Find(metroTextBox5.Text);
                        if (varRow == null)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Kode obat tidak terdaftar untuk dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            varRow.Delete();
                            MySqlCommandBuilder cmd = new MySqlCommandBuilder(varDA);
                            varDA.Update(varDS, "obat");
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

        private void metroTextBox6_TextChanged(object sender, EventArgs e)
        {
            string perintah = "SELECT * FROM obat WHERE nama_obat LIKE '%"+ metroTextBox6.Text +"%'";
            dataGridView1.DataSource = funct.cari(perintah);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bersihkan();
            metroTextBox1.Focus();
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            try
            {
                    if (metroTextBox1.Text == "")
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Pilih kode obat yang akan di ubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        DataColumn[] pk = { varDS.Tables["obat"].Columns["id_obat"] };
                        varDS.Tables["obat"].PrimaryKey = pk;
                        varRow = varDS.Tables["obat"].Rows.Find(metroTextBox5.Text);
                        if (varRow == null)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Kode obat tidak terdaftar untuk di ubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            varRow.BeginEdit();
                            varRow[1] = metroTextBox1.Text;
                            varRow[2] = metroTextBox2.Text;
                            varRow[3] = metroTextBox3.Text;
                            varRow[4] = metroTextBox4.Text;
                            varRow.EndEdit();
                            MySqlCommandBuilder cmd = new MySqlCommandBuilder(varDA);
                            varDA.Update(varDS, "obat");
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

        private void button1_Click(object sender, EventArgs e)
        {
            bersihkan();
            metroTextBox1.Focus();
            penomoranotoamtis();
        }
    }
}

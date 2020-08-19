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
    public partial class FormKamar : MetroFramework.Forms.MetroForm
    {
        funct funct = new funct();
        MySqlDataAdapter varDA = new MySqlDataAdapter();
        DataSet varDS = new DataSet();
        DataRow varRow;
        MySqlCommand varComm = new MySqlCommand();
        public FormKamar()
        {
            InitializeComponent();
        }
        void tampildata()
        {
            varDA = new MySqlDataAdapter("SELECT * FROM kamar", funct.Getconn());
            varDA.Fill(varDS, "kamar");
            dataGridView1.DataSource = varDS.Tables["kamar"];
        }
        void penomiranotomatis()
        {
            metroTextBox1.Text = funct.penomoranotomatis("kamar","KMR-","kodeKamar");
        }
        void bersihkan()
        {
            metroTextBox1.Text = "";
            metroTextBox2.Text = "";
            metroTextBox3.Text = "";
            metroTextBox4.Text = "";
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
        void hitungrecord()
        {
            lblrecord.Text = varDS.Tables["kamar"].Rows.Count.ToString();
        }
        private void FormKamar_Load(object sender, EventArgs e)
        {
            dgvstyle();
            tampildata();
            hitungrecord();
        }
        private void metroTextBox6_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = funct.cari("SELECT * FROM kamar WHERE kodeKamar LIKE '%" + metroTextBox6.Text + "%' OR namaKamar LIKE '%" + metroTextBox6.Text + "%'");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bersihkan();
            penomiranotomatis();
            metroTextBox2.Focus();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            bersihkan();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                metroTextBox1.Text = Convert.ToString(varDS.Tables["kamar"].Rows[dataGridView1.CurrentRow.Index].ItemArray[0]);
                metroTextBox2.Text = Convert.ToString(varDS.Tables["kamar"].Rows[dataGridView1.CurrentRow.Index].ItemArray[1]);
                metroTextBox3.Text = Convert.ToString(varDS.Tables["kamar"].Rows[dataGridView1.CurrentRow.Index].ItemArray[2]);
                metroTextBox4.Text = Convert.ToString(varDS.Tables["kamar"].Rows[dataGridView1.CurrentRow.Index].ItemArray[3]);
            }
            catch (Exception)
            {
                bersihkan();
                penomiranotomatis();
            }
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBox1.Text == "" || metroTextBox2.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data masih ada yang kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DataColumn[] pk = { varDS.Tables["kamar"].Columns["kodeKamar"] };
                    varDS.Tables["kamar"].PrimaryKey = pk;
                    varRow = varDS.Tables["kamar"].Rows.Find(metroTextBox1.Text);
                    if (varRow == null)
                    {
                        varRow = varDS.Tables["kamar"].NewRow();
                        varRow[0] = metroTextBox1.Text;
                        varRow[1] = metroTextBox2.Text;
                        varRow[2] = metroTextBox3.Text;
                        varRow[3] = metroTextBox4.Text;
                        varDS.Tables["kamar"].Rows.Add(varRow);
                        MySqlCommandBuilder cmd = new MySqlCommandBuilder(varDA);
                        varDA.Update(varDS, "kamar");
                        MetroFramework.MetroMessageBox.Show(this, "Data berhasil di simpan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersihkan();
                        hitungrecord();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Kode kamar sudah ada", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBox1.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Pilih kode kamar yang akan di ubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DataColumn[] pk = {varDS.Tables["kamar"].Columns["kodeKamar"] };
                    varDS.Tables["kamar"].PrimaryKey = pk;
                    varRow = varDS.Tables["kamar"].Rows.Find(metroTextBox1.Text);
                    if (varRow == null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Kode kamar tidak terdaftar untuk di ubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        varRow.BeginEdit();
                        varRow[1] = metroTextBox2.Text;
                        varRow[2] = metroTextBox3.Text;
                        varRow[3] = metroTextBox4.Text;
                        varRow.EndEdit();
                        MySqlCommandBuilder cmd = new MySqlCommandBuilder(varDA);
                        varDA.Update(varDS, "kamar");
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

        private void btnhapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Yakin ingin menghapus data ini?", "Question", MessageBoxButtons.OKCancel , MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (metroTextBox1.Text == "")
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Pilih kode kamar yang akan di hapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        DataColumn[] pk = { varDS.Tables["kamar"].Columns["kodeKamar"] };
                        varDS.Tables["kamar"].PrimaryKey = pk;
                        varRow = varDS.Tables["kamar"].Rows.Find(metroTextBox1.Text);
                        if (varRow == null)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Kode kamar tidak terdaftar untuk di hapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            varRow.Delete();
                            MySqlCommandBuilder cmd = new MySqlCommandBuilder(varDA);
                            varDA.Update(varDS, "kamar");
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
    }
}

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
    public partial class FormTindakan : MetroFramework.Forms.MetroForm
    {
        funct funct = new funct();
        MySqlDataAdapter varDA = new MySqlDataAdapter();
        MySqlCommand varComm = new MySqlCommand();
        DataSet varDS = new DataSet();
        DataSet varDS1 = new DataSet();
        DataRow varRow;
        public FormTindakan()
        {
            InitializeComponent();
        }
        void tampildata()
        {
            varDA = new MySqlDataAdapter("SELECT * FROM tindakan", funct.Getconn());
            varDA.Fill(varDS, "tindakan");
            dataGridView1.DataSource = varDS.Tables["tindakan"];
        }
        void tampildata1()
        {
            MySqlDataAdapter varDA1 = new MySqlDataAdapter("SELECT * FROM konsul_spesial", funct.Getconn());
            varDA1.Fill(varDS1, "konsul_spesial");
            dataGridView2.DataSource = varDS1.Tables["konsul_spesial"];
        }
        void hitungrecord()
        {
            lblrecord.Text = varDS.Tables["tindakan"].Rows.Count.ToString();
        }

        void hitungrecord1()
        {
            lblrecord1.Text = varDS1.Tables["konsul_spesial"].Rows.Count.ToString();
        }
        void penomoranotomatis()
        {
            metroTextBox5.Text = funct.penomoranotomatis("tindakan","TDK-","kodeTindakan");
        }
        void bersihkan()
        {
            metroTextBox5.Text = "";
            metroTextBox1.Text = "";
            metroTextBox2.Text = "";
            numericUpDown1.Value = 0;
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
        void dgvstyle1()
        {
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.EnableHeadersVisualStyles = false;
        }
        private void FormTindakan_Load(object sender, EventArgs e)
        {
            dgvstyle();
            dgvstyle1();
            tampildata();
            hitungrecord();
            tampildata1();
            hitungrecord1();
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                metroTextBox5.Text = Convert.ToString(varDS.Tables["tindakan"].Rows[dataGridView1.CurrentRow.Index].ItemArray[0]);
                metroTextBox1.Text = Convert.ToString(varDS.Tables["tindakan"].Rows[dataGridView1.CurrentRow.Index].ItemArray[1]);
                numericUpDown1.Value = Convert.ToInt32(varDS.Tables["tindakan"].Rows[dataGridView1.CurrentRow.Index].ItemArray[2]);
                metroTextBox2.Text = Convert.ToString(varDS.Tables["tindakan"].Rows[dataGridView1.CurrentRow.Index].ItemArray[3]);
            }
            catch (Exception)
            {
                bersihkan();
                penomoranotomatis();
            }
        }

        private void metroTextBox6_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = funct.cari(@"SELECT * FROM tindakan WHERE
                                                    kodeTindakan LIKE '%" + metroTextBox6.Text + "%' OR namaTindakan LIKE '%" + metroTextBox6.Text + "%' OR harga_tindakan LIKE '%" + metroTextBox6.Text + "%' OR ket LIKE '%" + metroTextBox6.Text + "%'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bersihkan();
            penomoranotomatis();
            metroTextBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bersihkan();
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBox5.Text == "" || metroTextBox1.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data masih ada yang kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DataColumn[] pk = { varDS.Tables["tindakan"].Columns["kodeTindakan"] };
                    varDS.Tables["tindakan"].PrimaryKey = pk;
                    varRow = varDS.Tables["tindakan"].Rows.Find(metroTextBox5.Text);
                    if (varRow == null)
                    {
                        varRow = varDS.Tables["tindakan"].NewRow();
                        varRow[0] = metroTextBox5.Text;
                        varRow[1] = metroTextBox1.Text;
                        varRow[2] = numericUpDown1.Value;
                        varRow[3] = metroTextBox2.Text;
                        varDS.Tables["tindakan"].Rows.Add(varRow);
                        MySqlCommandBuilder cmd = new MySqlCommandBuilder(varDA);
                        varDA.Update(varDS, "tindakan");
                        MetroFramework.MetroMessageBox.Show(this, "Data berhasil di simpan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersihkan();
                        hitungrecord();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Kode tindakan sudah ada", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBox5.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Pilih data yang akan di ubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DataColumn[] pk = { varDS.Tables["tindakan"].Columns["kodeTindakan"] };
                    varDS.Tables["tindakan"].PrimaryKey = pk;
                    varRow = varDS.Tables["tindakan"].Rows.Find(metroTextBox5.Text);
                    if (varRow == null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Kode tindakan tidak terdaftar untuk di ubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        varRow.BeginEdit();
                        varRow[1] = metroTextBox1.Text;
                        varRow[2] = numericUpDown1.Value;
                        varRow[3] = metroTextBox2.Text;
                        varRow.EndEdit();
                        MySqlCommandBuilder cmd = new MySqlCommandBuilder(varDA);
                        varDA.Update(varDS, "tindakan");
                        MetroFramework.MetroMessageBox.Show(this, "Data berhasil di ubah", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersihkan();
                        hitungrecord();
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Yakin ingin menghapus data ini ?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (metroTextBox5.Text == "")
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Pilih data yang akan di hapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        DataColumn[] pk = { varDS.Tables["tindakan"].Columns["kodeTindakan"] };
                        varDS.Tables["tindakan"].PrimaryKey = pk;
                        varRow = varDS.Tables["tindakan"].Rows.Find(metroTextBox5.Text);
                        if (varRow == null)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Kode tindakan tidak terdaftar untuk dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            varRow.Delete();
                            MySqlCommandBuilder cmd = new MySqlCommandBuilder(varDA);
                            varDA.Update(varDS, "tindakan");
                            MetroFramework.MetroMessageBox.Show(this, "Data berhasil di hapus", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bersihkan();
                            hitungrecord();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroTextBox3_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = funct.cari(@"SELECT * FROM konsul_spesial WHERE
                                                    kodespealis LIKE '%" + metroTextBox3.Text + "%' OR nama_spesialis LIKE '%" + metroTextBox3.Text + "%'");
        }

    }
}

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
    public partial class FormDokter : MetroFramework.Forms.MetroForm
    {
        funct funct = new funct();
        DataSet varDs = new DataSet();
        MySqlDataAdapter varDA = new MySqlDataAdapter();
        MySqlCommand varComm = new MySqlCommand();
        DataRow varRow;
        public FormDokter()
        {
            InitializeComponent();
        }

        private void FormDokter_Load(object sender, EventArgs e)
        {
            dgvstyle();
            tampildata();
            hitungrecord();
        }
        void hitungrecord()
        {
            lblrecord.Text = varDs.Tables["dokter"].Rows.Count.ToString();
        }
        void tampildata()
        {
            string perintah = "SELECT * FROM dokter";
            varDA = new MySqlDataAdapter(perintah, funct.Getconn());
            varDA.Fill(varDs, "dokter");
            dataGridView1.DataSource = varDs.Tables["dokter"];
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

        private void metroTextBox5_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM dokter WHERE kodeDokter LIKE '%" + metroTextBox5.Text + "%' OR namaDokter LIKE '%" + metroTextBox5.Text + "%' OR spesialis LIKE '%" + metroTextBox5.Text + "%' OR jk LIKE '%" + metroTextBox5.Text + "%' OR alamat LIKE '%" + metroTextBox5.Text + "%' OR no_hp LIKE '%" + metroTextBox5.Text + "%'";
            dataGridView1.DataSource =  funct.cari(sql);
        }
        void penomoranotomatis()
        {
            metroTextBox1.Text = funct.penomoranotomatis("dokter","DTR-","kodeDokter");
        }
        void bersihkan()
        {
            metroTextBox1.Text = "";
            metroTextBox2.Text = "";
            metroTextBox3.Text = "";
            metroComboBox1.ResetText();
            metroTextBox4.Text = "";
            metroTextBox6.Text = "";
        }
        private void btnsimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (@"" + metroTextBox1.Text == "" || metroTextBox2.Text == "" ||
                    metroTextBox3.Text == "" || metroTextBox4.Text == "" || 
                    metroComboBox1.Text == "" || metroTextBox6.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Form masih ada yang kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DataColumn[] pk = { varDs.Tables["dokter"].Columns["kodeDokter"] };
                    varDs.Tables["dokter"].PrimaryKey = pk;
                    varRow = varDs.Tables["dokter"].Rows.Find(metroTextBox1.Text);
                    if (varRow == null)
                    {
                        varRow = varDs.Tables["dokter"].NewRow();
                        varRow[0] = metroTextBox1.Text;
                        varRow[1] = metroTextBox2.Text;
                        varRow[2] = metroTextBox3.Text;
                        varRow[3] = metroComboBox1.Text;
                        varRow[4] = metroTextBox4.Text;
                        varRow[5] = metroTextBox6.Text;
                        varDs.Tables["dokter"].Rows.Add(varRow);
                        MySqlCommandBuilder cmd = new MySqlCommandBuilder(varDA);
                        varDA.Update(varDs, "dokter");
                        MetroFramework.MetroMessageBox.Show(this, "Data Berhasil di simpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hitungrecord();
                        bersihkan();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Kode dokter sudah ada", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                if (MetroFramework.MetroMessageBox.Show(this,"Yakin ingin menghapus data ini?","Question",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (metroTextBox1.Text == "")
                    {
                        funct.kesalahan("Pilih kode dokter yang akan di hapus");
                    }
                    else
                    {
                        DataColumn[] pk = {varDs.Tables["dokter"].Columns["kodeDokter"]};
                        varDs.Tables["dokter"].PrimaryKey = pk;
                        varRow = varDs.Tables["dokter"].Rows.Find(metroTextBox1.Text);
                        if (varRow == null)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Kode dokter tidak terdaftar untuk di hapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            varRow.Delete();
                            MySqlCommandBuilder cmd = new MySqlCommandBuilder(varDA);
                            varDA.Update(varDs, "dokter");
                            MetroFramework.MetroMessageBox.Show(this, "Data Berhasil di hapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            hitungrecord();
                            bersihkan();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            try
            {
                if(metroTextBox1.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Pilih kode dokter yang akan di ubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DataColumn[] pk = { varDs.Tables["dokter"].Columns["kodeDokter"] };
                    varDs.Tables["dokter"].PrimaryKey = pk;
                    varRow = varDs.Tables["dokter"].Rows.Find(metroTextBox1.Text);
                    if (varRow == null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Kode dokter tidak terdaftar untuk di ubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        varRow.BeginEdit();
                        varRow[1] = metroTextBox2.Text;
                        varRow[2] = metroTextBox3.Text;
                        varRow[3] = metroComboBox1.Text;
                        varRow[4] = metroTextBox4.Text;
                        varRow[5] = metroTextBox6.Text;
                        varRow.EndEdit();
                        MySqlCommandBuilder cmd = new MySqlCommandBuilder(varDA);
                        varDA.Update(varDs, "dokter");
                        MetroFramework.MetroMessageBox.Show(this, "Data berhasil di update", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                metroTextBox1.Text = Convert.ToString(varDs.Tables["dokter"].Rows[dataGridView1.CurrentRow.Index].ItemArray[0]);
                metroTextBox2.Text = Convert.ToString(varDs.Tables["dokter"].Rows[dataGridView1.CurrentRow.Index].ItemArray[1]);
                metroTextBox3.Text = Convert.ToString(varDs.Tables["dokter"].Rows[dataGridView1.CurrentRow.Index].ItemArray[2]);
                metroComboBox1.Text = Convert.ToString(varDs.Tables["dokter"].Rows[dataGridView1.CurrentRow.Index].ItemArray[3]);
                metroTextBox4.Text = Convert.ToString(varDs.Tables["dokter"].Rows[dataGridView1.CurrentRow.Index].ItemArray[4]);
                metroTextBox6.Text = Convert.ToString(varDs.Tables["dokter"].Rows[dataGridView1.CurrentRow.Index].ItemArray[5]);
            }
            catch (Exception)
            {
                bersihkan();
                penomoranotomatis();
                dataGridView1.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bersihkan();
            penomoranotomatis();
            metroTextBox2.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}

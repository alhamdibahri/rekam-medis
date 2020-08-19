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
    public partial class FormPasien : MetroFramework.Forms.MetroForm
    {
        funct funct = new funct();
        MySqlDataAdapter varDA = new MySqlDataAdapter();
        DataRow varRow;
        MySqlCommand varComm = new MySqlCommand();
        DataSet varDS = new DataSet();
        string jk;
        public FormPasien()
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
            varDA = new MySqlDataAdapter("SELECT * FROM pasien", funct.Getconn());
            varDA.Fill(varDS, "pasien");
            dataGridView1.DataSource = varDS.Tables["pasien"];
        }
        void hitungrecord()
        {
            lblrecord.Text = varDS.Tables["pasien"].Rows.Count.ToString();
        }
        void penomoranotomatis()
        {
            kodepasien.Text = funct.penomoranotomatis("pasien", "PSN-", "kodepasien");
        }
        void bersihkan()
        {
            namapasien.Focus();
            namapasien.Text = "";
            kodepasien.Text = "";
            alamat.Text = "";
            umur.Value = 0;
            tgl_lahir.Text = "";
            tgl_daftar.Text = "";
            metroRadioButton1.Checked = false;
            metroRadioButton2.Checked = false;
            status.Text = "";
            telepon.Text = "";
            penomoranotomatis();
            lbljam.Text = DateTime.Now.ToString("hh:mm");
        }
        private void FormPasien_Load(object sender, EventArgs e)
        {
            dgvstyle();
            tampildata();
            hitungrecord();
        }

        private void metroTextBox6_TextChanged(object sender, EventArgs e)
        {
            string perintah = "SELECT * FROM pasien WHERE kodepasien LIKE '%" + metroTextBox6.Text + "%' OR namapasien LIKE '%" + metroTextBox6.Text + "%' OR tgl_lahir LIKE '%" + metroTextBox6.Text + "%' OR jk LIKE '%" + metroTextBox6.Text + "%' OR alamat LIKE '%" + metroTextBox6.Text + "%' OR umur LIKE '%" + metroTextBox6.Text + "%' OR tgl_daftar LIKE '%" + metroTextBox6.Text + "%' OR jam_daftar LIKE '%" + metroTextBox6.Text + "%' OR teleponpasien LIKE '%" + metroTextBox6.Text + "%' OR status LIKE '%" + metroTextBox6.Text + "%'";
            dataGridView1.DataSource = funct.cari(perintah);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                kodepasien.Text = Convert.ToString(varDS.Tables["pasien"].Rows[dataGridView1.CurrentRow.Index].ItemArray[0]);
                namapasien.Text = Convert.ToString(varDS.Tables["pasien"].Rows[dataGridView1.CurrentRow.Index].ItemArray[1]);
                tgl_lahir.Text = Convert.ToString(varDS.Tables["pasien"].Rows[dataGridView1.CurrentRow.Index].ItemArray[2]);
                if (Convert.ToString(varDS.Tables["pasien"].Rows[dataGridView1.CurrentRow.Index].ItemArray[3]) == "Laki-Laki")
                {
                    metroRadioButton1.Checked = true;
                }
                else
                {
                    metroRadioButton2.Checked = true;
                }
                alamat.Text = Convert.ToString(varDS.Tables["pasien"].Rows[dataGridView1.CurrentRow.Index].ItemArray[4]);
                umur.Value = Convert.ToInt32(varDS.Tables["pasien"].Rows[dataGridView1.CurrentRow.Index].ItemArray[5]);
                tgl_daftar.Text = Convert.ToString(varDS.Tables["pasien"].Rows[dataGridView1.CurrentRow.Index].ItemArray[6]);
                lbljam.Text = Convert.ToString(varDS.Tables["pasien"].Rows[dataGridView1.CurrentRow.Index].ItemArray[7]);
                telepon.Text = Convert.ToString(varDS.Tables["pasien"].Rows[dataGridView1.CurrentRow.Index].ItemArray[8]);
                status.Text = Convert.ToString(varDS.Tables["pasien"].Rows[dataGridView1.CurrentRow.Index].ItemArray[9]);
            }
            catch (Exception)
            {
                penomoranotomatis();
                bersihkan();
            }
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (@"" + kodepasien.Text == "" ||
                    namapasien.Text == "" || alamat.Text == ""
                    || umur.Value == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data masih kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DataColumn[] pk = { varDS.Tables["pasien"].Columns["kodepasien"] };
                    varDS.Tables["pasien"].PrimaryKey = pk;
                    varRow = varDS.Tables["pasien"].Rows.Find(kodepasien.Text);
                    if (varRow == null)
                    {
                        varRow = varDS.Tables["pasien"].NewRow();
                        varRow[0] = kodepasien.Text;
                        varRow[1] = namapasien.Text;
                        varRow[2] = tgl_lahir.Value.ToString("yyyy-MM-dd");
                        varRow[3] = jk;
                        varRow[4] = alamat.Text;
                        varRow[5] = umur.Value;
                        varRow[6] = tgl_daftar.Value.ToString("yyyy-MM-dd");
                        varRow[7] = lbljam.Text;
                        varRow[8] = telepon.Text;
                        varRow[9] = status.Text;
                        varDS.Tables["pasien"].Rows.Add(varRow);
                        MySqlCommandBuilder cmd = new MySqlCommandBuilder(varDA);
                        varDA.Update(varDS, "pasien");
                        MetroFramework.MetroMessageBox.Show(this, "Data berhasil di simpan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tampildata();
                        bersihkan();
                        hitungrecord();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Kode pasien sudah ada", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton1.Checked == true)
            {
                jk = "Laki-Laki";
            }
            else
            {
                jk = "Perempuan";
            }
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton2.Checked == true)
            {
                jk = "Perempuan";
            }
            else
            {
                jk = "Laki=Laki";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbljam.Text = DateTime.Now.ToString("hh:mm");
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Yakin ingin menghapus data ini?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (kodepasien.Text == "")
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Pilih kode pasien yang akan di hapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        DataColumn[] pk = { varDS.Tables["pasien"].Columns["kodepasien"] };
                        varDS.Tables["pasien"].PrimaryKey = pk;
                        varRow = varDS.Tables["pasien"].Rows.Find(kodepasien.Text);
                        if (varRow == null)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Kode pasien tidak terdaftar untuk dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            varRow.Delete();
                            MySqlCommandBuilder cmd = new MySqlCommandBuilder(varDA);
                            varDA.Update(varDS, "pasien");
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
            namapasien.Focus();
            penomoranotomatis();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bersihkan();
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            try
            {
                if (kodepasien.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Pilih kode pasien yang akan di ubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DataColumn[] pk = { varDS.Tables["pasien"].Columns["kodepasien"] };
                    varDS.Tables["pasien"].PrimaryKey = pk;
                    varRow = varDS.Tables["pasien"].Rows.Find(kodepasien.Text);
                    if (varRow == null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Kode pasien tidak terdaftar untuk di ubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        varRow.BeginEdit();
                        varRow[1] = namapasien.Text;
                        varRow[2] = tgl_lahir.Value.ToString("yyyy-MM-dd");
                        varRow[3] = jk;
                        varRow[4] = alamat.Text;
                        varRow[5] = umur.Value;
                        varRow[6] = tgl_daftar.Value.ToString("yyyy-MM-dd");
                        varRow[7] = lbljam.Text;
                        varRow[8] = telepon.Text;
                        varRow[9] = status.Text;
                        varRow.EndEdit();
                        MySqlCommandBuilder cmd = new MySqlCommandBuilder(varDA);
                        varDA.Update(varDS, "pasien");
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
    }
}

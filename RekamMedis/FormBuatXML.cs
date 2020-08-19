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
    public partial class FormBuatXML : Form
    {
        funct funct = new funct();
        DataSet varDS = new DataSet();
        MySqlDataAdapter varDA = new MySqlDataAdapter();
        MySqlCommand varComm = new MySqlCommand();
        public FormBuatXML()
        {
            InitializeComponent();
        }
        private void FormBuatXML_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = funct.Getconn();
            try
            {
                varComm.Connection = conn;
                varComm.CommandText = @"SELECT r.nomorRM,o.namapasien,p.nama_penyakit FROM rekammedik r, pasien o, penyakit p WHERE r.id_penyakit=p.id_penyakit AND r.kodepasien=o.kodepasien";
                varDA.SelectCommand = varComm;
                varDA.Fill(varDS, "penyakit");

                varDS.WriteXml(@"E:\penyakit.xml", XmlWriteMode.WriteSchema);
                MessageBox.Show("Data Report dalam bentuk XML Berhasil dibuat", "Pesan Simpan XML", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Pesan Simpan XML",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

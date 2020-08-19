using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RekamMedis
{
    public partial class MainLaporan : Form
    {
        public MainLaporan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            LaporanObat lprn = new LaporanObat();
            lprn.ShowDialog();
            lprn = null;
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            LaporanKunjunganPasien lprn = new LaporanKunjunganPasien();
            lprn.ShowDialog();
            lprn = null;
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            LaporanPenyakit lprn = new LaporanPenyakit();
            lprn.ShowDialog();
            lprn = null;
            Show();
        }
    }
}

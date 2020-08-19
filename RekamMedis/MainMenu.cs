using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RekamMedis
{
    public partial class MainMenu : Form
    {
        bool islogin = false;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            islogin = false;
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Hide();
            FormMaster mstr = new FormMaster();
            mstr.ShowDialog();
            mstr = null;
            Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            GantiPass chngpass = new GantiPass();
            chngpass.ShowDialog();
            chngpass = null;
            Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Hide();
            FormCariPasien rkmmedik = new FormCariPasien();
            rkmmedik.ShowDialog();
            rkmmedik = null;
            Show();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (islogin == false)
            {
                Login lgn = new Login();
                lgn.Close();
            }
            else
            {
                Login lgn = new Login();
                lgn.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            islogin = true;
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            FormRegistrasiPasien rgstpasn = new FormRegistrasiPasien();
            rgstpasn.ShowDialog();
            rgstpasn = null;
            Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Hide();
            MainLaporan lprn = new MainLaporan();
            lprn.ShowDialog();
            lprn = null;
            Show();
        }
    }
}

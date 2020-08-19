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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rectangleShape2.Width += 5;
            if (rectangleShape2.Width >= 343)
            {
                timer1.Stop();
                Login lgn = new Login();
                Hide();
                lgn.ShowDialog();
                lgn = null;
                Close();
            }
        }
    }
}

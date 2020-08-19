using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace RekamMedis
{
    public partial class GantiPass : Form
    {
        funct funct = new funct();
        MySqlDataReader rd;
        MySqlCommand cmd = new MySqlCommand();
        public GantiPass()
        {
            InitializeComponent();
        }
        void bersihkan()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox1.Focus();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox1.UseSystemPasswordChar == false)
            {
                Button3.Text = "Show";
                TextBox1.UseSystemPasswordChar = true;
            }
            else
            {
                Button3.Text = "Hide";
                TextBox1.UseSystemPasswordChar = false;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "")
            {
                MessageBox.Show("All field is required!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MySqlConnection conn = funct.Getconn();
                string md5text1 = funct.CreateMD5Hash(TextBox1.Text);
                string md5text2 = funct.CreateMD5Hash(TextBox2.Text);
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM user_man WHERE password='" + md5text1 + "'", conn);
                rd = cmd.ExecuteReader();
                rd.Read();
                if (!rd.HasRows)
                {
                    MessageBox.Show("Account not found!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    rd.Close();
                    cmd = new MySqlCommand("UPDATE user_man SET password='" + md5text2 + "' WHERE password='"+ md5text1 +"' ", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil memperbaharui password", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersihkan();
                }
            }
        }

        private void GantiPass_Load(object sender, EventArgs e)
        {
            TextBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bersihkan();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (TextBox2.UseSystemPasswordChar == false)
            {
                Button4.Text = "Show";
                TextBox2.UseSystemPasswordChar = true;
            }
            else
            {
                Button4.Text = "Hide";
                TextBox2.UseSystemPasswordChar = false;
            }
        }
    }
}

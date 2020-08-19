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
    public partial class Login : Form
    {
        funct funct = new funct();
        public Login()
        {
            InitializeComponent();
        }
        void bersihkan()
        {
            username.Text = "";
            password.Text = "";
            username.Focus();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Yakin ingin keluar dari aplikasi?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = funct.Getconn();
            try
            {
                conn.Open();
                string md5 = funct.CreateMD5Hash(password.Text);
                if (username.Text == "" || password.Text == "")
                {
                    MessageBox.Show("USERNAME DAN PASSWORD KOSONG!!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM user_man WHERE username='"+ username.Text +"' AND password='"+ md5 +"'", conn);
                    MySqlDataReader  rd = cmd.ExecuteReader();
                    MainMenu main = new MainMenu();
                    if (!rd.Read())
                    {
                        MessageBox.Show("USERNAME DAN PASSWORD SALAH!!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (Convert.ToString(rd["level"]) == "Petugas")
                        {
                            Hide();
                            main.txtuser.Text = "Selamat Datang, " + Convert.ToString(rd["nama"]);
                            main.Button2.Enabled = false;
                            main.ShowDialog();
                            main = null;
                            Close();
                            bersihkan();
                        }
                        else
                        {
                            Hide();
                            main.txtuser.Text = "Selamat Datang, " + Convert.ToString(rd["nama"]);
                            main.ShowDialog();
                            main = null;
                            Close();
                            bersihkan();
                        }
                    }
                    rd.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Login_Load(object sender, EventArgs e)
        {
            username.Focus();
            password.UseSystemPasswordChar = true;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            bersihkan();
        }
    }
}

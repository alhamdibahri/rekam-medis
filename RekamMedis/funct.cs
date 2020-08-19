using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;
namespace RekamMedis
{
    public class funct
    {
        public MySqlConnection conn = new MySqlConnection();
        public MySqlDataAdapter da = new MySqlDataAdapter();
        public MySql.Data.MySqlClient.MySqlConnection Getconn()
        {
            MySqlConnection conn = new MySqlConnection();
            conn = new MySqlConnection("Server=localhost;Database=rekam_medis;Uid=root;Pwd=;");
            return conn;
        }
        public string CreateMD5Hash(string input)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }
        public string penomoranotomatis(string table, string data,string kolom)
        {
            MySqlConnection conn = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader rd;
            funct koneksi = new funct();
            conn = koneksi.Getconn();
            string simpan;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM "+ table +"";
            rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Close();
                cmd.CommandText = "SELECT " + kolom + " FROM " + table + " ORDER BY " + kolom + " desc limit 1";
                simpan = string.Format("" + data + "{0,3:00#}", Convert.ToInt32(cmd.ExecuteScalar().ToString().Substring(4)) + 1);
            }
            else
            {
                simpan = "" + data + "001";
            }
            conn.Close();
            return simpan;
        }
        public DataTable cari(string sql)
        {
            MySqlConnection conn = new MySqlConnection();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand();
            funct koneksi = new funct();
            DataSet ds = new DataSet();
            conn = koneksi.Getconn();
            conn.Open();
            cmd = new MySqlCommand(sql, conn);
            da.SelectCommand = cmd;
            da.Fill(ds);
            dt = ds.Tables[0];
            return dt;
        }
        public int success(string data)
        {
            MessageBox.Show(data,"Success!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            return 0;
        }
        public int error(string data)
        {
            MessageBox.Show(data,"Peringatan!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            return 0;
        }
        public int kesalahan(string data)
        {
            MessageBox.Show(data, "Pesan Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return 0;
        }
        public bool tanya(string data)
        {
            if (MessageBox.Show(data,"Question!",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int insertdata(string table, string column, string values)
        {
            funct funct = new funct();
            MySqlConnection conn = funct.Getconn();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO "+ table +" (" + column + ") VALUES("+ values +")", conn);
            cmd.ExecuteReader();
            return 0;
        }
        public int updatedata(string table , string set, string where)
        {
            funct funct = new funct();
            MySqlConnection conn = funct.Getconn();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE " + table + " set " + set + " WHERE " + where + "", conn);
            cmd.ExecuteReader();
            return 0;
        }
        public int deletedata(string table, string where)
        {
            funct funct = new funct();
            MySqlConnection conn = funct.Getconn();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM " + table + " WHERE " + where + "", conn);
            cmd.ExecuteReader();
            return 0;
        }
    }
}

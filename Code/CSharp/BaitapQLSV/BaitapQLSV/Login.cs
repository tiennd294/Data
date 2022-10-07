using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaitapQLSV
{
    public partial class Login : Form
    {
        private SqlConnection con;
        private DataTable dt = new DataTable("User");
        public SqlDataAdapter da;
        private void ketnoi1()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=NGUYEN-99B795AB\SQLEXPRESS;Initial Catalog=QLKH;Integrated Security=True";
            con.Open(); 
        }
        public void exit()
        {
            con.Close();
            con.Dispose();
            con = null;
        }

        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand();
            com.Connection=con;
            com.CommandType = CommandType.Text;
            com.CommandText = @"Select * From User Where (Name=@Name) And (Pass=@Pass)";
            com.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = txtName.Text;
            com.Parameters.Add("@Pass", SqlDbType.NVarChar, 50).Value = txtPass.Text;
            da.SelectCommand = com;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Form1 frm = new Form1();
                frm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Dang nhap that bai!", "Dang Nhap", MessageBoxButtons.OK);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ketnoi1();
            txtName.Text = "QUANLYBANHANG";
            this.AcceptButton = btnLogin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}

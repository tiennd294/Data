using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TestQuanbLyBanHang
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                ketnoi kn = new ketnoi();
                kn.ket_noi();
                cmd.Connection = kn.con;

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DangNhap ", kn.con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                // Đưa dữ liệu lên textbox1
                //textBox1.Text = dt.Rows[0][0].ToString();

                if ((this.textBox1.Text == dt.Rows[0][1].ToString()))
                {
                    if (textBox2.Text.ToString() == textBox3.Text.ToString())
                    {
                        DataTable dt2 = new DataTable();
                        cmd.CommandText = System.String.Concat("UPDATE DangNhap SET Pass='" + textBox2.Text.ToString() + "'");
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();

                        this.Close();
                        MessageBox.Show("Thay Doi Mat Khau Thanh Cong!","Chuc Mung Ban..");
                    }
                    else MessageBox.Show("Mat Khau Moi Khong Trung Khop!","Nhap Lai!");
                }
                else
                {

                    MessageBox.Show("Sai Mat Khau!", "Thông báo");
                    this.textBox1.Focus();
                }
            }
            catch
            { }
        }
    }
}

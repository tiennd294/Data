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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        public void hienthi()
        {
            SqlCommand cmd1 = new SqlCommand();
            ketnoi kn1 = new ketnoi();
            kn1.ket_noi();
            cmd1.Connection = kn1.con;
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaKH FROM KhachHang", kn1.con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "MaKH";

        }

        public void loaddata2()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                ketnoi kn = new ketnoi();
                kn.ket_noi();
                cmd.Connection = kn.con;

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HoaDon WHERE MaKH='" + comboBox1.Text.ToString() + "'", kn.con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                // Đưa dữ liệu lên DataGridView
                dataGridView1.DataSource = dt;
                // Thay đổi độ rộng cột
                dataGridView1.AutoResizeColumns();


            }
            catch
            { }
        }

        public void loaddata()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                ketnoi kn = new ketnoi();
                kn.ket_noi();
                cmd.Connection = kn.con;

                SqlDataAdapter da = new SqlDataAdapter("SELECT Count(*) FROM HoaDon WHERE MaKH='" + comboBox1.Text.ToString() + "'", kn.con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                // Đưa dữ liệu lên textbox1

                textBox1.Text = dt.Rows[0][0].ToString();

            }
            catch
            { }
        }


        private void Form11_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loaddata2();
            loaddata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

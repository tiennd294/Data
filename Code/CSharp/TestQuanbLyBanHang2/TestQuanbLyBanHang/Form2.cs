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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string tg="dung";
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

                if ((this.textBox1.Text == dt.Rows[0][0].ToString()) && (this.textBox2.Text ==dt.Rows[0][1].ToString() ))
                {
                   
                    DataTable dt2 = new DataTable();
                    //int r = dataGridView1.CurrentCell.RowIndex;
                    // MaKH hiện hành 
                    //string str = dataGridView1.Rows[r].Cells[0].Value.ToString();
                    // Câu lệnh SQL
                    cmd.CommandText = System.String.Concat("UPDATE DangNhap SET TG='dung'");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    this.Close();
                }
                else
                {

                    MessageBox.Show("Không đúng tên người dùng / mật khẩu !!!", "Thông báo");
                    this.textBox1.Focus();
                }
            }
            catch
            { }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                QuanLy Ql = new QuanLy();
                Ql.Huy();
                Application.Exit();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    //string tg="dung";
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

                    if ((this.textBox1.Text == dt.Rows[0][0].ToString()) && (this.textBox2.Text == dt.Rows[0][1].ToString()))
                    {

                        DataTable dt2 = new DataTable();
                        //int r = dataGridView1.CurrentCell.RowIndex;
                        // MaKH hiện hành 
                        //string str = dataGridView1.Rows[r].Cells[0].Value.ToString();
                        // Câu lệnh SQL
                        cmd.CommandText = System.String.Concat("UPDATE DangNhap SET TG='dung'");
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();

                        this.Close();
                    }
                    else
                    {

                        MessageBox.Show("Không đúng tên người dùng / mật khẩu !!!", "Thông báo");
                        this.textBox1.Focus();
                    }
                }
                catch
                { }
                

            }
        }
    }
}

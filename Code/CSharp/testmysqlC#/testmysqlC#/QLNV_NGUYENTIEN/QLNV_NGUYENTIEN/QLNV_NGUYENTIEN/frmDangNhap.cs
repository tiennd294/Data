using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNV_NGUYENTIEN
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
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
                DataTable dt = new DataTable();
                dt = Sqlhelper.ExecuteDataTable_SQL("select * from Users where name ='" + textBox1.Text.ToString() + "' and pass='" + textBox2.Text.ToString() + "'");
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("danh nhap thanh cong");
                    this.Hide();
                    Form1 admin = new Form1();
                    admin.Show();
                }
                else
                    MessageBox.Show("danh nhap khong thanh cong");
            }
            catch { }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            DataTable tb =  Sqlhelper.MySqlExecuteDataTable_SQL("select * from User");
            dataGridView1.DataSource = tb;
        }
    }
}

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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        bool add;
        String gt;
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        public void Loaddata()
        {
            DataTable dt = new DataTable();
            dt = Sqlhelper.ExecuteDataTable_SQL("select * from NhanVien");
            dataGridView1.DataSource = dt;

            DataTable database = new DataTable();
            database = Sqlhelper.ExecuteDataTable_SQL("select MaPhongBan,TenPhongBan from PhongBan");
            comboBox2.DataSource = database;
            comboBox2.ValueMember = "MaPhongBan";
            comboBox2.DisplayMember = "TenPhongBan";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow r = dataGridView1.CurrentRow;
                textmanv.Text = r.Cells["MaNhanVien"].Value.ToString();
                textTennv.Text = r.Cells["TenNhanVien"].Value.ToString();
                textngaysinh.Text =r.Cells["NgaySinh"].Value.ToString();
                textdiachi.Text = r.Cells["DiaChi"].Value.ToString();
                textmanv.Enabled = false;
                textTennv.Enabled = false;
                textngaysinh.Enabled = false;
                textdiachi.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textmanv.Text = "";
            textTennv.Text = "";
            textngaysinh.Text = "";
            textdiachi.Text = "";
            textmanv.Enabled = true;
            textTennv.Enabled = true;
            textngaysinh.Enabled = true;
            textdiachi.Enabled = true;
            comboBox2.Enabled = true;
            comboBox1.Enabled = true;
            textmanv.Focus();
            add = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (add == true)
                {
                    
                    if (comboBox1.Text == "Nam")
                        gt = "true";
                    if (comboBox1.Text == "Nu")
                        gt = "false";
                    Sqlhelper.ExecuteNonQuery_SQL("insert into NhanVien(MaNhanVien,TenNhanVien,Ngaysinh,GioiTinh,Diachi,maPhongBan) values ('" + textmanv.Text.ToString() + "','" + textTennv.Text.ToString() + "','"+textngaysinh.Text.ToString()+"','"+gt.ToString()+"','"+textdiachi.Text.ToString()+"','"+comboBox2.Text.ToString()+"')");
                    MessageBox.Show("Insert thanh cong", "Thong bao");
                    Loaddata();
                }
            }
            catch { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("ban co chac chan muon xoa khong?", "Thog bao", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (Sqlhelper.isTrungMa("select * from NhanVien where MaNhanVien='" + textmanv.Text.ToString() + "'"))
                        Sqlhelper.ExecuteNonQuery_SQL("delete from NhanVien where MaNhanVien='" + textmanv.Text.ToString() + "'");
                    Loaddata();
                }
            }
            catch { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textmanv.Enabled = true;
            textTennv.Enabled = true;
            textngaysinh.Enabled = true;
            textdiachi.Enabled = true;
            comboBox2.Enabled = true;
            comboBox1.Enabled = true;
        }
    }
}

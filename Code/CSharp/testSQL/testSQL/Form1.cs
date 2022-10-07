using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace testSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        public SqlCommand com;
        //ham load du lieu len datagrid
        public void load()
        {
            string sql = "select * from khoa";
            DataTable dt = kn.ham(sql);
            dgv.DataSource = dt;
        }
        public void add(string a,string b)
        {
            com = new SqlCommand();
            com.Connection = kn.con;
            //DataTable dt = new DataTable();
            string sql = "insert into khoa(makhoa,tenkhoa)values(@makhoa,@tenkhoa)";
            com.CommandText = sql;
            com.Parameters.Add("@makhoa", SqlDbType.NChar).Value = a.ToString();
            com.Parameters.Add("@tenkhoa",SqlDbType.NVarChar).Value = b.ToString();
            com.ExecuteNonQuery();
            //xong them moi
        }
        //ham cap nhat du lieu
        public void update(string a,string b)
        {
            //ma khoa la khoa chinh nen khong the cap nhat ma khoa ma chi cap nhat ten khoa
            string sql = "update khoa set tenkhoa='"+a.ToString()+"'where makhoa='"+b.ToString()+"'";
            com = new SqlCommand();
            com.Connection = kn.con;
            com.CommandText = sql;
            com.ExecuteNonQuery();//muon hay hon thi bat try catch tai day lun nhung ma a thich bat o duoi hon

        }
        public void xoa()
        {
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                add(txtMa.Text.ToString(),txtTen.Text.ToString());
                MessageBox.Show("Thêm moi thanh cong");
                load();
            }
            catch (Exception ie)
            {
                MessageBox.Show("Thêm mới thất bại "+ie);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                update(txtTen.Text.ToString(), dgv.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Cập nhật thành công");
                load();
            }
            catch (Exception ie)
            {
                MessageBox.Show("Cập nhật thất bại "+ie);
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgv.CurrentRow.Cells[1].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string m = "delete khoa where makhoa='" + dgv.CurrentRow.Cells[0].Value.ToString() + "'";
            kn.ham(m);//a vier 
            load();
        }
           
}}
  
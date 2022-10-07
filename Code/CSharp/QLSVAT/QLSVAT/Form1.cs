using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QLSVAT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        xuli kn = new xuli();
        //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");
        int dong;
        bool themoi;
        public void setnull()
        {
            txtMa.Text = "";
            txtTen.Text = "";
        }
        public void locktext()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
        }
        public void un_locktext()
        {
            txtMa.Enabled = true;
            txtTen.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }
        public void khoitao()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].HeaderText = "Ma Khoa";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[0].Frozen = true;
            dataGridView1.Columns[1].HeaderText = "Ten Khoa";
            dataGridView1.Columns[1].Width = 300;

        }
        public void hienthi()
        {
            SqlDataAdapter ad = new SqlDataAdapter("select * from khoa", kn.con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            hienthi();
            khoitao();
            locktext();
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtMa.Text = dataGridView1.Rows[dong].Cells[0].Value.ToString();
            txtTen.Text = dataGridView1.Rows[dong].Cells[1].Value.ToString();//a viet lai het lun nha a oi
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (themoi == true)
            {
                SqlCommand comm = new SqlCommand("insert into khoa values(N'" + txtMa.Text + "',N'" + txtTen.Text+"')",kn.con);
                try
                {
                    comm.ExecuteNonQuery();
                    hienthi();
                    MessageBox.Show("Da Them");
                    locktext();
                }
                catch
                {
                    MessageBox.Show("Loi");
                }
            }
            else
                if (themoi == true)
                {
                    SqlCommand comm = new SqlCommand("update khoa set tenkhoa=N'" + txtTen.Text + "'where makhoa=N'" + txtMa.Text + "'", kn.con);
                    try
                    {
                        comm.ExecuteNonQuery();
                        hienthi();
                        MessageBox.Show("Da Luu");
                    }
                    catch
                    {
                        MessageBox.Show("Loi");
                    }
                }

            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = false;
            un_locktext();
            themoi = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string m = "delete khoa where makhoa='"+dataGridView1.CurrentRow.Cells[0].Value.ToString()+"'";
            kn.ham(m);
            hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setnull();
            un_locktext();
            themoi = true;
            
        }
    }
}

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
    public partial class frmPhongBan : Form
    {
        public frmPhongBan()
        {
            InitializeComponent();
        }
        bool add;
        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        public void Loaddata()
        {
            DataTable dt = new DataTable();
            dt = Sqlhelper.ExecuteDataTable_SQL("select * from PhongBan");
            dataGridView1.DataSource = dt;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add = true;
            txtTenPb.Text = "";
            textmapb.Text = "";
            textmapb.Enabled = true;
            txtTenPb.Enabled = true;
            textmapb.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (add == true)
                {
                    Sqlhelper.ExecuteNonQuery_SQL("insert into PhongBan(MaPhongBan,TenPhongBan) values ('" + textmapb.Text.ToString() + "','" + txtTenPb.Text.ToString() + "')");
                    MessageBox.Show("Insert thanh cong", "Thong bao");
                    Loaddata();
                }
                else
                {
                    //Sqlhelper.ExecuteNonQuery_SQL("update PhongBan(TenPhongBan) set '" + textmapb.Text.ToString() + "','" + txtTenPb.Text.ToString() + "'");
                    //MessageBox.Show("Edit thanh cong", "Thong bao");
                    //Loaddata();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("loi roi" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            add = false;
            textmapb.Enabled = true;
            txtTenPb.Enabled = true;
            textmapb.Focus();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow r = dataGridView1.CurrentRow;
                textmapb.Text = r.Cells["MaPhongBan"].Value.ToString();
                txtTenPb.Text = r.Cells["TenphongBan"].Value.ToString();
                textmapb.Enabled = false;
                txtTenPb.Enabled = false;
            }
            catch { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("ban co chac chan muon xoa khong?", "Thog bao", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (Sqlhelper.isTrungMa("select * from Phongban where maPhongBan='" + textmapb.Text.ToString() + "'"))
                        Sqlhelper.ExecuteNonQuery_SQL("delete from Phongban where maPhongBan='" + textmapb.Text.ToString() + "'");
                    Loaddata();
                }
            }
            catch { }
        }
    }
}

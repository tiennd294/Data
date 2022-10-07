using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Public;
using BUL;

//using System.Data;

namespace QuanLySV
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }
        SinhVienBUL svbul = new SinhVienBUL();
        SinhVienPublic p = new SinhVienPublic();
        public void loaddata()
        {
            dataGridView1.DataSource = svbul.DanhSachSV();
            //comboBox1.DataSource = svbul.Danhsachmasv();
            //comboBox1.DisplayMember = "tensv";
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            loaddata();
       
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                p.Name = textBox1.Text;
                p.Pass = textBox2.Text;
                p.Avartar = maskedTextBox1.Text.ToString();
                p.MaLop = int.Parse(textBox3.Text);
                svbul.ThemSV(p);
                loaddata();
                MessageBox.Show("Insert thanh cong!");
            }
            catch { MessageBox.Show("loi roi!"); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            string Masv= dataGridView1.Rows[r].Cells[0].Value.ToString();

            //p.MaSV = int.Parse(textBox1.Text);
            //p.TenSV = textBox2.Text;
            //p.NamSinh = DateTime.Parse(maskedTextBox1.Text);
            //p.MaLop = int.Parse(textBox3.Text);
            svbul.SuaSV(p);
            loaddata();
            MessageBox.Show("Edit thanh cong");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                try
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    //pictureBox2.Image = row.Cells[4].Value.GetType() ;
                    textBox1.Text=Convert.ToString(row.Cells[0].Value);
                    textBox2.Text = Convert.ToString(row.Cells[1].Value);
                    textBox3.Text = Convert.ToString(row.Cells[3].Value);
                    //DateTime dt = DateTime.ParseExact(row.Cells[2].Value, "ddMMyyyy", CultureInfoConverter);
                    //dt.ToString("yyyyMMdd");
                    maskedTextBox1.Text= String.Format("{0:MM/dd/yyyy}", row.Cells[2].Value);
                                        
                }
                catch { }
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            string Masv = dataGridView1.Rows[r].Cells[0].Value.ToString();
            //p.MaSV = int.Parse(Masv);
            svbul.XoaSV(p);
            loaddata();
            MessageBox.Show("Delete thanh cong!");
        }
    }
}

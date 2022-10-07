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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        

        private void Form3_Load(object sender, EventArgs e)
        {
            
            try
            {

                SqlCommand cmd = new SqlCommand();
                ketnoi kn = new ketnoi();
                kn.ket_noi();
                cmd.Connection = kn.con;
                SqlDataAdapter da = null;
                
            
                int intDM = Convert.ToInt32(this.Text);
                switch (intDM)
                {
                    case 1:
                            lblDM.Text = "Danh Mục Thành Phố";
                            da = new SqlDataAdapter("SELECT ThanhPho, TenThanhPho FROM ThanhPho", kn.con);
                            break;
                    case 2:
                            lblDM.Text = "Danh Mục Khách Hàng";
                            da = new SqlDataAdapter("SELECT MaKH, TenCty FROM KhachHang", kn.con);
                            break;
                    case 3:
                            lblDM.Text = "Danh Mục Nhân Viên";
                            da = new SqlDataAdapter("SELECT MaNV, Ho, Ten FROM NhanVien", kn.con);
                            break;
                    case 4:
                            lblDM.Text = "Danh Mục Sản Phẩm";
                            da = new SqlDataAdapter("SELECT MaSP, TenSP, DonViTinh, DonGia FROM SanPham", kn.con);
                            break;
                    case 5:
                            lblDM.Text = "Danh Mục Hóa Đơn";
                            da = new SqlDataAdapter("SELECT MaHD, MaKH, MaNV FROM HoaDon", kn.con);
                            break;
                    case 6:
                            lblDM.Text = "Danh Mục Chi Tiết Hóa Đơn";
                            da = new SqlDataAdapter("SELECT * FROM ChiTietHoaDon", kn.con);
                            break;
                    default:
                            break;
                  }
                            
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt =new DataTable();
                
                dt.Clear();
                da.Fill(dt);
                            
                dataGridView1.DataSource = dt;
                dataGridView1.AutoResizeColumns();
             }
             catch (SqlException)
             {
                    MessageBox.Show("Không lấy được nội dung trong table. Lỗi rồi!!!");

             }
         }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

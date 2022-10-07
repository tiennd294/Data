using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace TestQuanbLyBanHang
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private XDocument LoadXmlDocument(string url)
        {
            //Hầm load một file xml vào đối tượng XDocument
            try
            {
                return XDocument.Load(url);
            }
            catch
            {
                return null;
            }
        }

        
        private void Form3_Load(object sender, EventArgs e)
        {
            
            try
            {

                //SqlCommand cmd = new SqlCommand();
                //ketnoi kn = new ketnoi();
                //kn.ket_noi();
                //cmd.Connection = kn.con;
                //SqlDataAdapter da = null;
                XDocument doc = LoadXmlDocument("data.xml");
                DataTable dtb = new DataTable();
            
                int tg = Convert.ToInt32(this.Text);
                switch (tg)
                {
                    case 1:
                            {
                                try
                                {
                                    lblDM.Text = "Danh Mục Thành Phố";
                                    //da = new SqlDataAdapter("SELECT ThanhPho, TenThanhPho FROM ThanhPho", kn.con);
                                    dtb.Columns.Add("Thành Phố");
                                    dtb.Columns.Add("Tên Thành Phố");

                                    foreach (XElement p in doc.Descendants("ThanhPho"))
                                    {
                                        DataRow row = dtb.NewRow();

                                        row[0] = p.Attribute("Thanhpho").Value;
                                        row[1] = p.Element("TenTP").Value;

                                        dtb.Rows.Add(row); // Thêm dòng mới vào dtb
                                    
                                    }
                                }
                                catch { }
                                 break;
                            }
                    case 2:
                            
                            {
                                try
                                {
                                    this.Text = "Danh Mục Khách Hàng";
                                    lblDM.Text = "Danh Mục Khách Hàng";
                                    //da = new SqlDataAdapter("SELECT ThanhPho, TenThanhPho FROM ThanhPho", kn.con);
                                    dtb.Columns.Add("Mã Khách Hàng");
                                    dtb.Columns.Add("Tên Công Ty");
                                    dtb.Columns.Add("Địa Chỉ");
                                    dtb.Columns.Add("Thành Phố");
                                    dtb.Columns.Add("Điện Thoại");

                                    foreach (XElement p in doc.Descendants("KhachHang"))
                                    {
                                        DataRow row = dtb.NewRow();

                                        row[0] = p.Attribute("MaKH").Value;
                                        row[1] = p.Element("TenCTy").Value;
                                        row[2] = p.Element("DiaChi").Value;
                                        row[3] = p.Element("Thanhpho").Value;
                                        row[4] = p.Element("DienThoai").Value;

                                        dtb.Rows.Add(row); // Thêm dòng mới vào dtb
                                        
                                    }
                                }
                                catch { }
                                break;
                            }
                    case 3:
                            {    
                                    //da = new SqlDataAdapter("SELECT MaNV, Ho, Ten FROM NhanVien", kn.con);
                                try
                                {
                                    lblDM.Text = "Danh Mục Nhân Viên";
                                    //da = new SqlDataAdapter("SELECT ThanhPho, TenThanhPho FROM ThanhPho", kn.con);
                                    dtb.Columns.Add("Mã Nhân Viên");
                                    dtb.Columns.Add("Họ Nhân Viên");
                                    dtb.Columns.Add("Tên Nhân Viên");
                                    dtb.Columns.Add("Giới Tính");
                                    dtb.Columns.Add("Năm Sinh");
                                    dtb.Columns.Add("Địa Chỉ");
                                    dtb.Columns.Add("Điện Thoại");
                                    
                                    foreach (XElement p in doc.Descendants("NhanVien"))
                                    {
                                        DataRow row = dtb.NewRow();

                                        row[0] = p.Attribute("MaNV").Value;
                                        row[1] = p.Element("Ho").Value;
                                        row[2] = p.Element("Ten").Value;
                                        row[3] = p.Element("GT").Value;
                                        row[4] = p.Element("NamSinh").Value;
                                        row[5] = p.Element("DiaChi").Value;
                                        row[6] = p.Element("DienThoai").Value;
                                        
                                        

                                        dtb.Rows.Add(row); // Thêm dòng mới vào dtb
                                    
                                    }
                                }
                                catch { }
                                 break;
                            }
                    case 4:
                            
                            //da = new SqlDataAdapter("SELECT MaSP, TenSP, DonViTinh, DonGia FROM SanPham", kn.con);
                            {
                                try
                                {
                                    lblDM.Text = "Danh Mục Sản Phẩm";
                                    //da = new SqlDataAdapter("SELECT ThanhPho, TenThanhPho FROM ThanhPho", kn.con);
                                    dtb.Columns.Add("Mã Sản Phẩm");
                                    dtb.Columns.Add("Tên Sản Phẩm");
                                    dtb.Columns.Add("Đơn Vị Tính");
                                    dtb.Columns.Add("Đơn Giá");
                                    dtb.Columns.Add("Hình Ảnh");

                                    foreach (XElement p in doc.Descendants("SanPham"))
                                    {
                                        DataRow row = dtb.NewRow();

                                        row[0] = p.Attribute("MaSP").Value;
                                        row[1] = p.Element("TenSP").Value;
                                        row[2] = p.Element("DonViTinh").Value;
                                        row[3] = p.Element("DonGia").Value;
                                        row[4] = p.Element("Hinh").Value;

                                        dtb.Rows.Add(row); // Thêm dòng mới vào dtb

                                    }
                                }
                                catch { }
                                break;
                            }
                    case 5:
                            
                            //da = new SqlDataAdapter("SELECT MaHD, MaKH, MaNV FROM HoaDon", kn.con);
                            {
                                try
                                {
                                    lblDM.Text = "Danh Mục Hóa Đơn";
                                    //da = new SqlDataAdapter("SELECT ThanhPho, TenThanhPho FROM ThanhPho", kn.con);
                                    dtb.Columns.Add("Mã Hóa Đơn");
                                    dtb.Columns.Add("Mã Khách Hàng");
                                    dtb.Columns.Add("Ma Nhân Viên");
                                    

                                    foreach (XElement p in doc.Descendants("HoaDon"))
                                    {
                                        DataRow row = dtb.NewRow();

                                        row[0] = p.Attribute("MaHD").Value;
                                        row[1] = p.Element("MaKH").Value;
                                        row[2] = p.Element("MaNV").Value;
                                        
                                        dtb.Rows.Add(row); // Thêm dòng mới vào dtb

                                    }
                                }
                                catch { }
                                break;
                            }
                    case 6:
                            
                            //da = new SqlDataAdapter("SELECT * FROM ChiTietHoaDon", kn.con);
                            {
                                try
                                {
                                    lblDM.Text = "Danh Mục Chi Tiết Hóa Đơn";
                                    //da = new SqlDataAdapter("SELECT ThanhPho, TenThanhPho FROM ThanhPho", kn.con);
                                    
                                    dtb.Columns.Add("Mã Hóa Đơn");
                                    dtb.Columns.Add("Ma Sản Phẩm");
                                    dtb.Columns.Add("Số Lượng");

                                    foreach (XElement p in doc.Descendants("ChiTietHD"))
                                    {
                                        DataRow row = dtb.NewRow();

                                        row[0] = p.Element("MaHD").Value;
                                        row[1] = p.Element("MaSP").Value;
                                        row[2] = p.Element("SoLuong").Value;
                                        
                                        dtb.Rows.Add(row); // Thêm dòng mới vào dtb

                                    }
                                }
                                catch { }
                                break;
                            }
                    default:
                            break;
                  }
                            
                //DataSet ds = new DataSet();
                //da.Fill(ds);
                //DataTable dt =new DataTable();
                
                //dt.Clear();
                //da.Fill(dt);
                            
                dataGridView1.DataSource = dtb;
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

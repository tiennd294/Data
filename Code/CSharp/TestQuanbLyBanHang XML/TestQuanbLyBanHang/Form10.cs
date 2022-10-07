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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        int tg;
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

        


        private void Form10_Load(object sender, EventArgs e)
        {
            try
            {
                tg = Convert.ToInt32(this.Text);
                XDocument doc = LoadXmlDocument("data.xml");
                switch (tg)
                {
                    case 1:
               
                        this.Text = "Quan Ly Khach Hang Theo Thanh Pho";
                        lblTP.Text = "Chon Thanh Pho";
                        lblTSKH.Text = "Tong So Khach Hang";
                        //da = new SqlDataAdapter("SELECT ThanhPho, TenThanhPho FROM ThanhPho", kn.con);
                        
                        foreach (XElement p in doc.Descendants("ThanhPho"))
                        {
                            comboBox1.Items.Add(p.Attribute("Thanhpho").Value.ToString());
                        }
                        break;
                    case 2:

                        this.Text = "Quan Ly Hoa Don Theo Khach Hang";
                        lblTP.Text = "Chon Khach Hang";
                        lblTSKH.Text = "Tong So Hoa Don";
                        foreach (XElement p in doc.Descendants("KhachHang"))
                        {
                            comboBox1.Items.Add(p.Attribute("MaKH").Value.ToString());
                        }
                        break;
                    case 3:

                        this.Text = "Quan Ly Hoa Don Theo San Pham";
                        lblTP.Text = "Chon San Pham";
                        lblTSKH.Text = "Tong So San Pham";
                         foreach (XElement p in doc.Descendants("SanPham"))
                        {
                            comboBox1.Items.Add(p.Element("TenSP").Value.ToString());
                        }
                        break;
                    case 4:

                        this.Text = "Quan Ly Hoa Don Theo Nhan Vien";
                        lblTP.Text = "Chon Nhan Vien";
                        lblTSKH.Text = "Tong So Nhan Vien";
                        foreach (XElement p in doc.Descendants("NhanVien"))
                        {
                            comboBox1.Items.Add(p.Attribute("MaNV").Value.ToString());
                        }
                        break;
                    case 5:

                        this.Text = "Quan Ly Chi Tiet Hoa Don Theo Hoa Don";
                        lblTP.Text = "Chon Hoa Don";
                        lblTSKH.Text = "Tong So Hoa Don";
                        foreach (XElement p in doc.Descendants("HoaDon"))
                        {
                            comboBox1.Items.Add(p.Attribute("MaHD").Value.ToString());
                        }
                        break;
                           
                    default:
                            break;
                }
                
            }
            catch (Exception)
            { MessageBox.Show("loi roi"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                int TS = 0;
                XDocument doc = LoadXmlDocument("data.xml");
                DataTable dtb = new DataTable();
                switch (tg)
                {
                    case 1:
                        
                            dtb.Columns.Add("Mã Khách Hàng");
                            dtb.Columns.Add("Tên Công Ty");
                            dtb.Columns.Add("Địa Chỉ");
                            dtb.Columns.Add("Thành Phố");
                            dtb.Columns.Add("Điện Thoại");

                            foreach (XElement p in doc.Descendants("KhachHang"))
                            {

                                if (p.Element("Thanhpho").Value == comboBox1.Text)
                                {
                                    DataRow row = dtb.NewRow();

                                    row[0] = p.Attribute("MaKH").Value;
                                    row[1] = p.Element("TenCTy").Value;
                                    row[2] = p.Element("DiaChi").Value;
                                    row[3] = p.Element("Thanhpho").Value;
                                    row[4] = p.Element("DienThoai").Value;

                                    dtb.Rows.Add(row); // Thêm dòng mới vào dtb
                                    TS = TS + 1;
                                }
                            }
                            break;
                    case 2:

                            dtb.Columns.Add("Mã Hóa Đơn");
                            dtb.Columns.Add("Mã Khách Hàng");
                            dtb.Columns.Add("Ma Nhân Viên");
                            dtb.Columns.Add("Ngày Lập Hóa Đơn");
                            dtb.Columns.Add("Ngày Nhận Hàng");

                            foreach (XElement p in doc.Descendants("HoaDon"))
                            {

                                if (p.Element("MaKH").Value == comboBox1.Text)
                                {
                                    DataRow row = dtb.NewRow();

                                    row[0] = p.Attribute("MaHD").Value;
                                    row[1] = p.Element("MaKH").Value;
                                    row[2] = p.Element("MaNV").Value;
                                    row[3] = p.Element("NgayLHD").Value;
                                    row[4] = p.Element("NgayNH").Value;

                                    dtb.Rows.Add(row); // Thêm dòng mới vào dtb
                                    TS = TS + 1;
                                }
                            }
                            break;
                    case 3:
                            {
                                
                                dtb.Columns.Add("Mã Hóa Đơn");
                                dtb.Columns.Add("Mã Khách Hàng");
                                dtb.Columns.Add("Ma Nhân Viên");
                                dtb.Columns.Add("Ngày Lập Hóa Đơn");
                                dtb.Columns.Add("Ngày Nhận Hàng");
                                foreach (XElement p in doc.Descendants("SanPham"))
                                {
                                    if (p.Element("TenSP").Value == comboBox1.Text)
                                    {
                                        string st = p.Attribute("MaSP").Value;
                                        foreach (XElement p2 in doc.Descendants("ChiTietHD"))
                                        {
                                            if (p2.Element("MaHD").Value == st)
                                            {
                                                string st2 = p2.Element("MaHD").Value;
                                                foreach (XElement p3 in doc.Descendants("HoaDon"))
                                                {
                                                    if (p3.Attribute("MaHD").Value == st2)
                                                    {
                                                        DataRow row = dtb.NewRow();

                                                        row[0] = p3.Attribute("MaHD").Value;
                                                        row[1] = p3.Element("MaKH").Value;
                                                        row[2] = p3.Element("MaNV").Value;
                                                        row[3] = p3.Element("NgayLHD").Value;
                                                        row[4] = p3.Element("NgayNH").Value;

                                                        dtb.Rows.Add(row); // Thêm dòng mới vào dtb
                                                        TS = TS + 1;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            break;
                    case 4:
                            {
                                try
                                {
                                    

                                    dtb.Columns.Add("Mã Hóa Đơn");
                                    dtb.Columns.Add("Mã Khách Hàng");
                                    dtb.Columns.Add("Ma Nhân Viên");
                                    dtb.Columns.Add("Ngày Lập Hóa Đơn");
                                    dtb.Columns.Add("Ngày Nhận Hàng");
                                    foreach (XElement p in doc.Descendants("HoaDon"))
                                    {
                                        if (p.Element("MaNV").Value == comboBox1.Text)
                                        {
                                            
                                                    DataRow row = dtb.NewRow();

                                                    row[0] = p.Attribute("MaHD").Value;
                                                    row[1] = p.Element("MaKH").Value;
                                                    row[2] = p.Element("MaNV").Value;
                                                    row[3] = p.Element("NgayLHD").Value;
                                                    row[4] = p.Element("NgayNH").Value;

                                                    dtb.Rows.Add(row); // Thêm dòng mới vào dtb
                                                    TS = TS + 1;
                                                    
                                                    
                                        }
                                    }


                                }
                                catch(Exception)
                                { MessageBox.Show("loi roi"); }
                            }
                            break;
                        
                    default:
                        break;
                }
                dataGridView1.DataSource = dtb;
                dataGridView1.AutoResizeColumns();

                string str = Convert.ToString(TS);
                textBox1.Text = str;
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

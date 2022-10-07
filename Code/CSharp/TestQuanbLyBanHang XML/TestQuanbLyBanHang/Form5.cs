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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public bool Them2;

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

        public void loaddata()
        {
            try
            {

                XDocument doc = LoadXmlDocument("data.xml");
                DataTable dtb = new DataTable();
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
                    dataGridView1.DataSource = dtb;
                    dataGridView1.AutoResizeColumns();
                }
            }
            catch { }
        }

        public void loaddata2()
        {
            try
            {
              
                
                
               
                // Xóa trống các đối tượng trong Panel
                this.textBox1.ResetText();
                this.textBox2.ResetText();
                this.textBox3.ResetText();
                this.textBox4.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnLuu.Enabled = false;
                this.btnHuyBo.Enabled = false;
                //this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnTroVe.Enabled = true;
                
                // Không cho thao tác trên Panel
                this.groupBox1.Enabled = false;

            }
            catch
            { }
        }

        public void hienthi()
        {
           
            //SqlDataAdapter da = new SqlDataAdapter("SELECT ThanhPho FROM ThanhPho", kn1.con);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //comboBox1.DataSource = ds.Tables[0];
            //comboBox1.DisplayMember = "ThanhPho";
            try
            {


                XDocument doc = LoadXmlDocument("data.xml");
                DataTable dtb = new DataTable();
                
                //dtb.Columns.Add("Thành Phố");
               
                foreach (XElement p in doc.Descendants("ThanhPho"))
                {
                   comboBox1.Items.Add(p.Attribute("Thanhpho").Value.ToString());
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi" + ex);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            loaddata2();
            loaddata();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
                loaddata2();
                loaddata();
                hienthi();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them2 = true;
            // Xóa trống các đối tượng trong Panel
            this.textBox1.ResetText();
            this.textBox2.ResetText();
            this.textBox3.ResetText();
            this.textBox4.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.groupBox1.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;
            // Đưa con trỏ đến TextField txtThanhPho
            this.textBox1.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them2)
            {
                try
                {
                    XDocument xmlDoc = XDocument.Load("data.xml");

                    xmlDoc.Element("QLBH").Add(new XElement("KhachHang", new XAttribute("MaKH", textBox1.Text),
                                                                           new XElement("TenCTy", textBox2.Text),
                                                                           new XElement("DiaChi", textBox3.Text),
                                                                           new XElement("Thanhpho", comboBox1.Text),
                                                                           new XElement("DienThoai", textBox4.Text)));

                    xmlDoc.Save("data.xml");
                    loaddata();
                    loaddata2();

                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            if (!Them2)
            {

                try
                {

                    XDocument doc = LoadXmlDocument("data.xml");

                    {
                        //Nếu đã tồn tại sản phẩm có ID này rồi thì thực hiện cập nhật
                        XElement ele = doc.Descendants("KhachHang").Where(x => x.Attribute("MaKH").Value.Equals(textBox1.Text)).First();
                        ele.Attribute("MaKH").Value = textBox1.Text;
                        ele.Element("TenCTy").Value = textBox2.Text;
                        ele.Element("DiaChi").Value = textBox3.Text;
                        ele.Element("Thanhpho").Value = comboBox1.Text;
                        ele.Element("DienThoai").Value = textBox4.Text;
                        doc.Save("data.xml");
                    }
                    loaddata();
                    loaddata2();

                    MessageBox.Show("Đã sửa xong!");
                }
                catch { }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Them2 = false;
                // Cho phép thao tác trên Panel this.panel.Enabled = true;
                // Thứ tự dòng hiện hành
                int r = dataGridView1.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel 
                textBox1.ReadOnly = true;
                this.textBox1.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
                this.textBox2.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
                this.textBox3.Text = dataGridView1.Rows[r].Cells[2].Value.ToString(); 
                this.textBox4.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
                // Cho thao tác trên các nút Lưu / Hủy / Panel
                this.btnLuu.Enabled = true;
                this.btnHuyBo.Enabled = true;
                this.groupBox1.Enabled = true;
                // Không cho thao tác trên các nút Thêm / Xóa / Thoát
                this.btnThem.Enabled = false;
                this.btnSua.Enabled = false;
                this.btnXoa.Enabled = false;
                this.btnTroVe.Enabled = false;
                // Đưa con trỏ đến TextField txtMaKH
                this.textBox1.Focus();
            }
            catch { }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTroVe.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = false;
            this.btnHuyBo.Enabled = false;
            this.groupBox1.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                string str = dataGridView1.Rows[r].Cells[0].Value.ToString();

                //XmlNode node = doc.SelectSingleNode("//product[@id='" + txtID.SelectedText+ "']");
                XDocument xmldoc = XDocument.Load("data.xml");
                xmldoc.XPathSelectElement("//KhachHang[@MaKH='" + textBox1.Text + "']").Remove();
                xmldoc.Save("data.xml");
                loaddata();
                loaddata2();
            }
            catch { }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                comboBox1.Text = row.Cells[3].Value.ToString();
                textBox4.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}

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
    public partial class Form6 : Form
    {
        public Form6()
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
        public bool Them2;
        public void loaddata2()
        {
            try
            {
                XDocument doc = LoadXmlDocument("data.xml");
                DataTable dtb = new DataTable();
                //da = new SqlDataAdapter("SELECT ThanhPho, TenThanhPho FROM ThanhPho", kn.con);
                dtb.Columns.Add("Mã Hóa Đơn");
                dtb.Columns.Add("Mã Khách Hàng");
                dtb.Columns.Add("Mã Nhân Viên");
                dtb.Columns.Add("Ngày Lập Hóa Đơn");
                dtb.Columns.Add("Ngày Nhận Hàng");

                foreach (XElement p in doc.Descendants("HoaDon"))
                {
                    DataRow row = dtb.NewRow();

                    row[0] = p.Attribute("MaHD").Value;
                    row[1] = p.Element("MaKH").Value;
                    row[2] = p.Element("MaNV").Value;
                    row[3] = p.Element("NgayLHD").Value;
                    row[4] = p.Element("NgayNH").Value;

                    dtb.Rows.Add(row); // Thêm dòng mới vào dtb
                    dataGridView1.DataSource = dtb;
                    dataGridView1.AutoResizeColumns();
                }
                // Xóa trống các đối tượng trong Panel
                this.textBox1.ResetText();
                
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
            try
            {


                XDocument doc = LoadXmlDocument("data.xml");
                DataTable dtb = new DataTable();

                foreach (XElement p in doc.Descendants("KhachHang"))
                {
                    comboBox1.Items.Add(p.Attribute("MaKH").Value.ToString());
                }
                foreach (XElement p in doc.Descendants("NhanVien"))
                {
                    comboBox2.Items.Add(p.Attribute("MaNV").Value.ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("loi" + ex);
            }

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            loaddata2();
            hienthi();
            
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            loaddata2();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them2 = true;
            // Xóa trống các đối tượng trong Panel
            this.textBox1.ResetText();
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Them2 = false;
                // Cho phép thao tác trên Panel this.panel.Enabled = true;
                // Thứ tự dòng hiện hành
                int r = dataGridView1.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel 
                this.textBox1.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
                
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them2)
            {
                try
                {
                    XDocument xmlDoc = XDocument.Load("data.xml");

                    xmlDoc.Element("QLBH").Add(new XElement("HoaDon", new XAttribute("MaHD", textBox1.Text),
                                                                           new XElement("MaKH", comboBox1.Text),
                                                                           new XElement("MaNV", comboBox2.Text),
                                                                           new XElement("NgayLHD", maskedTextBox1.Text),
                                                                           new XElement("NgayNH", maskedTextBox2.Text)));

                    xmlDoc.Save("data.xml");
                    hienthi();
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
                        XElement ele = doc.Descendants("HoaDon").Where(x => x.Attribute("MaHD").Value.Equals(textBox1.Text)).First();
                        ele.Attribute("MaHD").Value = textBox1.Text;
                        ele.Element("MaKH").Value = comboBox1.Text;
                        ele.Element("MaNV").Value = comboBox2.Text;
                        ele.Element("NgayLHD").Value = maskedTextBox1.Text;
                        ele.Element("NgayNH").Value = maskedTextBox2.Text;
                        doc.Save("data.xml");
                    }
                    hienthi();
                    loaddata2();

                    MessageBox.Show("Đã sửa xong!");
                }
                catch { }
            }
        

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
                xmldoc.XPathSelectElement("//HoaDon[@MaHD='" + textBox1.Text + "']").Remove();
                xmldoc.Save("data.xml");
                hienthi();
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
                comboBox1.Text = row.Cells[1].Value.ToString();
                comboBox2.Text = row.Cells[2].Value.ToString();
                maskedTextBox1.Text = row.Cells[3].Value.ToString();
                maskedTextBox2.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}

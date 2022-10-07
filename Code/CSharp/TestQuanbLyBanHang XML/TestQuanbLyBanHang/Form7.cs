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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        public bool Them;
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

        public void loaddata2()
        {
            try
            {
                XDocument doc = LoadXmlDocument("data.xml");
                DataTable dtb = new DataTable();
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
                    dataGridView1.DataSource = dtb;
                    dataGridView1.AutoResizeColumns();
                }
                // Xóa trống các đối tượng trong Panel
                this.textBox1.ResetText();
                this.textBox2.ResetText();
                this.textBox3.ResetText();
                this.textBox4.ResetText();
                this.textBox5.ResetText();
                this.comboBox1.ResetText();
                this.maskedTextBox1.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnLuu.Enabled = false;
                this.btnHuyBo.Enabled = false;
                
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

        private void Form7_Load(object sender, EventArgs e)
        {
            loaddata2();
            
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            loaddata2();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.textBox1.ResetText();
            this.textBox2.ResetText();
            this.textBox3.ResetText();
            this.textBox4.ResetText();
            this.textBox5.ResetText();
            this.comboBox1.ResetText();
            this.maskedTextBox1.ResetText();
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
                Them = false;
                // Cho phép thao tác trên Panel this.panel.Enabled = true;
                // Thứ tự dòng hiện hành
                int r = dataGridView1.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel 
                this.textBox1.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
                this.textBox2.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
                this.textBox3.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
                this.textBox4.Text = dataGridView1.Rows[r].Cells[5].Value.ToString();
                this.textBox5.Text = dataGridView1.Rows[r].Cells[6].Value.ToString();
                this.comboBox1.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
                this.maskedTextBox1.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
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
            if (Them)
            {
                try
                {
                    XDocument xmlDoc = XDocument.Load("data.xml");
                    xmlDoc.Element("QLBH").Add(new XElement("NhanVien", new XAttribute("MaNV", textBox1.Text),
                                                                           new XElement("Ho", textBox2.Text),
                                                                           new XElement("Ten", textBox3.Text),
                                                                           new XElement("GT", comboBox1.Text),
                                                                           new XElement("NamSinh", maskedTextBox1.Text),
                                                                           new XElement("DiaChi", textBox4.Text),
                                                                           new XElement("DienThoai", textBox5.Text)
                                                                           ));
                    xmlDoc.Save("data.xml");
                    loaddata2();
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (Exception )
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            if (!Them)
            {
                try
                {
                    XDocument doc = LoadXmlDocument("data.xml");
                    {
                        //Nếu đã tồn tại sản phẩm có ID này rồi thì thực hiện cập nhật
                        XElement ele = doc.Descendants("NhanVien").Where(x => x.Attribute("MaNV").Value.Equals(textBox1.Text)).First();
                        ele.Attribute("MaNV").Value = textBox1.Text;
                        ele.Element("Ho").Value = textBox2.Text;
                        ele.Element("Ten").Value = textBox3.Text;
                        ele.Element("GT").Value = comboBox1.Text;
                        ele.Element("NamSinh").Value = maskedTextBox1.Text;
                        ele.Element("DiaChi").Value = textBox4.Text;
                        ele.Element("DienThoai").Value = textBox5.Text;
                        doc.Save("data.xml");
                    }
                    
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
                xmldoc.XPathSelectElement("//NhanVien[@MaNV='" + textBox1.Text + "']").Remove();
                xmldoc.Save("data.xml");
                
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
                maskedTextBox1.Text = row.Cells[4].Value.ToString();
                textBox4.Text = row.Cells[5].Value.ToString();
                textBox5.Text = row.Cells[6].Value.ToString();
            }
        }
    }
}

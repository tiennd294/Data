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
    public partial class Form4 : Form
    {
        public Form4()
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
        
        public void loaddata()
        {
            try
            {

                // Xóa trống các đối tượng trong Panel
                this.textBox1.ResetText();
                this.textBox2.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnLuu.Enabled = false;
                this.btnHuyBo.Enabled = false;
                //this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnTroVe.Enabled = true;
                this.groupBox1.Enabled = false;
                
               
                //XPathDocument ap = new XPathDocument("data.xml");
                //IXPathNavigable nav = ap.CreateNavigator();
                //XPathNodeIterator node = nav.select("/acacac");
                //XPathExpression expr;
                //expr = nav.Compile("//ThanhPho");


                //XPathNavigator nav;
                //XPathDocument docNav;
                //XPathNodeIterator NodeIter;
                //String strExpression;
                //docNav = new XPathDocument("data.xml");
                //nav = docNav.CreateNavigator();
                //strExpression = "//ThanhPho";
                //NodeIter = nav.Select(strExpression);
                //while (NodeIter.MoveNext())
                //{
                //    XPathNavigator nav2 = NodeIter.Current.Clone();
                //    dataGridView1.DataSource = nav2.Value;
                // }

                //dataGridView1.DataSource = NodeIter.Current.Value;
                


            }
            catch
            { }
        }

        public void Load_data()
        {
            try 
            {
             
                XDocument doc = LoadXmlDocument("data.xml");
                DataTable dtb = new DataTable();
                dtb.Columns.Add("Thành Phố");
                dtb.Columns.Add("Tên Thành Phố");


                foreach (XElement p in doc.Descendants("ThanhPho"))// day la j Descendants? cai nay e k hiu nua ok no add data vao datatable roi add 
                {
                    DataRow row = dtb.NewRow();
                    row[0] = p.Attribute("Thanhpho").Value;
                    row[1] = p.Element("TenTP").Value;
                    
                    dtb.Rows.Add(row);
                }

                dataGridView1.DataSource = dtb;
                dataGridView1.AutoResizeColumns();
            }
            catch(Exception ex)
            {
                MessageBox.Show("loi"+ex);
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            loaddata();
            Load_data();
            
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            loaddata();
            Load_data();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.textBox1.ResetText();
            this.textBox2.ResetText();
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
            Them = false;
            // Cho phép thao tác trên Panel this.panel.Enabled = true;
            // Thứ tự dòng hiện hành
            int r = dataGridView1.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.textBox1.Text = dataGridView1.Rows[r].Cells[0].Value.ToString(); 
            this.textBox2.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                string str = dataGridView1.Rows[r].Cells[0].Value.ToString();

                //XmlNode node = doc.SelectSingleNode("//product[@id='" + txtID.SelectedText+ "']");
                XDocument xmldoc = XDocument.Load("data.xml");
                xmldoc.XPathSelectElement("//ThanhPho[@Thanhpho='" + textBox1.Text + "']").Remove();
                xmldoc.Save("data.xml");
                loaddata();
                Load_data();
            }
            catch { }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel this.txtThanhPho.ResetText(); this.txtTenThanhPho.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnThem.Enabled = true; 
            this.btnSua.Enabled = true; 
            this.btnXoa.Enabled = true; 
            this.btnTroVe.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = false;
            this.btnHuyBo.Enabled = false;
            this.groupBox1.Enabled = false;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
            if (Them)
            {
                try
                {
                    XDocument xmlDoc = XDocument.Load("data.xml");

                    xmlDoc.Element("QLBH").Add(new XElement("ThanhPho", new XAttribute("Thanhpho", textBox1.Text),
                                                                           new XElement("TenTP", textBox2.Text)));

                    xmlDoc.Save("data.xml");
                    loaddata();
                    Load_data();
                    
                    MessageBox.Show("Đã thêm xong!");
                    }
                    catch (SqlException)
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
                        XElement ele = doc.Descendants("ThanhPho").Where(x => x.Attribute("Thanhpho").Value.Equals(textBox1.Text)).First();
                        ele.Attribute("Thanhpho").Value = textBox1.Text;
                        ele.Element("TenTP").Value = textBox2.Text;
                        doc.Save("data.xml");
                    }
                    loaddata();
                    Load_data();
                    
                    MessageBox.Show("Đã sửa xong!");
                }
                catch { }
            }
       
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
              
            }
        }
    }
}

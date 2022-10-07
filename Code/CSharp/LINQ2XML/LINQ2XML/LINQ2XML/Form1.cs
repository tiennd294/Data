using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Windows.Forms;


namespace LINQ2XML
{
    public partial class Form1 : Form
    {
        XmlDocument doc = new XmlDocument();
        //int CurrentNodeIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * Ví dụ demo xử dụng LINQ To XML
         * Phạm vi: mô phỏng đơn giản việc load dữ liệu từ file XML, Insert và Update một node
         * Giới hạn: Ví dụ không kiểm soát dữ liệu đầu vào
         * 
         * Author: serivn.cor@gmail.com
         * Homepage: http://ictsharing.i-svn.net or http://ictsharing.wordpress.com
         */

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

        private void LoadData()
        {
            try
            {
                //Hàm nạp dữ liệu từ file xml vào DataGridView
                //Load xml file to Xdocument
                XDocument doc = LoadXmlDocument("data.xml");
                DataTable dtb = new DataTable();
                dtb.Columns.Add("Mã Sản phẩm");
                dtb.Columns.Add("Tên sản phẩm");
                dtb.Columns.Add("Giá");

                foreach (XElement p in doc.Descendants("product"))
                {
                    DataRow row = dtb.NewRow();
                    if (p.Attribute("id").Value != "")
                    {
                        row[0] = p.Attribute("id").Value;
                        row[1] = p.Element("ProductName").Value;
                        row[2] = p.Element("ProductPrice").Value;

                        dtb.Rows.Add(row); // Thêm dòng mới vào dtb
                    }
                }

                dataGridView1.DataSource = dtb;
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy thông tin dòng hiện tại hiển thị ra các textbox
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtProductName.Text = row.Cells[1].Value.ToString();
                txtPrice.Text = row.Cells[2].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Xóa hết thông tin để thêm item mới
            txtID.Enabled = true;
            txtID.Text = "";
            txtPrice.Text = "";
            txtProductName.Text = "";
            txtID.Focus();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text != null && txtPrice.Text != "" && txtProductName.Text != "")
                {
                    //Load xml document
                    XDocument doc = LoadXmlDocument("data.xml");
                    if (doc.Descendants("product").Where(x => x.Attribute("id").Value.Equals(txtID.Text)).Count() == 1)
                    {
                        //Nếu đã tồn tại sản phẩm có ID này rồi thì thực hiện cập nhật
                        XElement ele = doc.Descendants("product").Where(x => x.Attribute("id").Value.Equals(txtID.Text)).First();
                        ele.Element("ProductName").Value = txtProductName.Text;
                        ele.Element("ProductPrice").Value = txtPrice.Text;
                        doc.Save("data.xml");
                    }
                    else
                    {
                        //Nếu chưa tồn tại product với id trên thì thêm mới
                        //doc.Descendants("product").Last().AddAfterSelf(new XElement("product",
                        //                                                new XAttribute("id", txtID.Text),
                        //                                                new XElement("ProductName", txtProductName.Text),
                        //                                                new XElement("ProductPrice", txtPrice.Text)));
                        XDocument xmlDoc = XDocument.Load("data.xml");

                        xmlDoc.Element("products").Add(new XElement("product", new XAttribute("id", txtID.Text),
                                                                               new XElement("ProductName", txtProductName.Text),
                                                                               new XElement("ProductPrice", txtPrice.Text)));

                        xmlDoc.Save("data.xml");

                        //doc.Save("data.xml");
                    }
                    txtID.Enabled = false;
                    LoadData();
                    button2.Enabled = true;
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("ex"+ex);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                string str = dataGridView1.Rows[r].Cells[0].Value.ToString();

                //XmlNode node = doc.SelectSingleNode("//product[@id='" + txtID.SelectedText+ "']");
                XDocument xmldoc = XDocument.Load("data.xml");
                xmldoc.XPathSelectElement("//product[@id='" + txtID.Text + "']").Remove();
                xmldoc.Save("data.xml");
                LoadData();
            }
            catch { }

        }


    }
}
